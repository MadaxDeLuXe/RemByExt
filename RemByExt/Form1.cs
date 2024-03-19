using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.CheckedListBox;

namespace RemByExt
{
    public partial class Form1 : Form
    {
        public List<DirectoryInfo> EmptyDirs = new List<DirectoryInfo>();

        public List<string> Extensions = new List<string>();
        public List<FileInfo> Fileinfos = new List<FileInfo>();

        internal List<FileInfo> toDelete = new List<FileInfo>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnPathSelect_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog foBro = new FolderBrowserDialog();
            if (foBro.ShowDialog() == DialogResult.OK)
            {
                tbPath.Text = foBro.SelectedPath;

                if (Extensions.Count > 0) { Extensions.Clear(); }
                if (clbExtensions.Items.Count > 0) { clbExtensions.Items.Clear(); }
                if (Fileinfos.Count > 0) { Fileinfos.Clear(); }

                Analyse(foBro.SelectedPath);

                clbExtensions.Items.AddRange(Extensions.ToArray());
            }
        }

        private void Apply()
        {
            int delCount = 0;
            foreach (FileInfo fi in toDelete)
            {
                fi.Delete();
                delCount++;
            }
            if (delCount == toDelete.Count) 
            { 
                toDelete.Clear();
                delCount = 0;
            }
            
            if (cbRemEmptyFolders.Checked)
            {
                foreach (DirectoryInfo di in EmptyDirs)
                {
                    di.Delete();
                    delCount++;
                }
                if (delCount == EmptyDirs.Count)
                {
                    EmptyDirs.Clear();
                    delCount = 0;
                }

                Analyse(tbPath.Text, true);

                if (EmptyDirs.Count > 0) 
                {
                    foreach (DirectoryInfo di in EmptyDirs)
                    {
                        di.Delete();
                        delCount++;
                    }
                }

                if (delCount == EmptyDirs.Count)
                {
                    EmptyDirs.Clear();
                    delCount = 0;

                    dgvToDelete.Rows.Clear();
                    clbExtensions.Items.Clear();
                }
            }
        }

        private void Analyse(string Path, bool skipFiles = false)
        {
            DirectoryInfo currentDir = new(Path);

            DirectoryInfo[] SubDirs = currentDir.GetDirectories();

            FileInfo[] Files = currentDir.GetFiles();

            if (Files.Length == 0 && SubDirs.Length == 0)
            {
                EmptyDirs.Add(currentDir);
                return;
            }

            if (Files.Count() > 0 && skipFiles == false)
            {
                foreach (FileInfo fi in Files)
                {
                    if (!Fileinfos.Contains(fi))
                    {
                        Fileinfos.Add(fi);
                    }

                    if (!Extensions.Contains(fi.Extension))
                    {
                        Extensions.Add(fi.Extension);
                    }
                }
            }

            if (SubDirs.Count() > 0)
            {
                foreach (DirectoryInfo di in SubDirs)
                {
                    Analyse(di.FullName);
                }
            }

            return;
        }

        private List<FileInfo> GenerateDeleteList(CheckedItemCollection checkedItemCollection)
        {
            List<FileInfo> toDelete = new List<FileInfo>();
            if (dgvToDelete.Rows.Count > 0) { dgvToDelete.Rows.Clear(); }


            foreach (FileInfo fi in Fileinfos)
            {
                if (checkedItemCollection.Contains(fi.Extension))
                {
                    if (!toDelete.Contains(fi))
                    {
                        toDelete.Add(fi);
                        dgvToDelete.Rows.Add(fi.FullName);
                    }
                }
                else
                {
                    if (toDelete.Contains(fi))
                    {
                        toDelete.Remove(fi);
                    }
                }
            }
            return toDelete;
        }

        private void btnListToDelete_Click(object sender, EventArgs e)
        {
            if (toDelete.Count > 0) { toDelete.Clear(); }

            if (clbExtensions.CheckedItems.Count > 0)
            {
                toDelete = GenerateDeleteList(clbExtensions.CheckedItems);
            }

            if (toDelete.Count > 0)
            {
                lblItemCount.Text = $"Items to delete: {toDelete.Count}";
                btnDelete.Enabled = true;
            }
            else
            {
                lblItemCount.Text = "Items to delete: 0";
                btnDelete.Enabled = false;
            }
        }

        private void btnAbort_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Apply();
        }        
    }
}
