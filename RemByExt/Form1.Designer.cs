namespace RemByExt
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnPathSelect = new Button();
            label1 = new Label();
            tbPath = new TextBox();
            dgvToDelete = new DataGridView();
            Pfad = new DataGridViewTextBoxColumn();
            clbExtensions = new CheckedListBox();
            label2 = new Label();
            btnListToDelete = new Button();
            lblItemCount = new Label();
            cbRemEmptyFolders = new CheckBox();
            btnDelete = new Button();
            btnAbort = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvToDelete).BeginInit();
            SuspendLayout();
            // 
            // btnPathSelect
            // 
            btnPathSelect.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPathSelect.Location = new Point(797, 21);
            btnPathSelect.Name = "btnPathSelect";
            btnPathSelect.Size = new Size(75, 23);
            btnPathSelect.TabIndex = 0;
            btnPathSelect.Text = "Select...";
            btnPathSelect.UseVisualStyleBackColor = true;
            btnPathSelect.Click += btnPathSelect_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 1;
            label1.Text = "Pfad:";
            // 
            // tbPath
            // 
            tbPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbPath.Location = new Point(52, 21);
            tbPath.Name = "tbPath";
            tbPath.ReadOnly = true;
            tbPath.Size = new Size(739, 23);
            tbPath.TabIndex = 2;
            // 
            // dgvToDelete
            // 
            dgvToDelete.AllowUserToAddRows = false;
            dgvToDelete.AllowUserToDeleteRows = false;
            dgvToDelete.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvToDelete.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvToDelete.Columns.AddRange(new DataGridViewColumn[] { Pfad });
            dgvToDelete.Location = new Point(12, 70);
            dgvToDelete.Name = "dgvToDelete";
            dgvToDelete.ReadOnly = true;
            dgvToDelete.RowHeadersVisible = false;
            dgvToDelete.Size = new Size(737, 379);
            dgvToDelete.TabIndex = 3;
            // 
            // Pfad
            // 
            Pfad.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Pfad.HeaderText = "Datei";
            Pfad.Name = "Pfad";
            Pfad.ReadOnly = true;
            // 
            // clbExtensions
            // 
            clbExtensions.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            clbExtensions.CheckOnClick = true;
            clbExtensions.FormattingEnabled = true;
            clbExtensions.Location = new Point(755, 88);
            clbExtensions.Name = "clbExtensions";
            clbExtensions.Size = new Size(120, 130);
            clbExtensions.TabIndex = 4;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(755, 70);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 5;
            label2.Text = "Ext to delete:";
            // 
            // btnListToDelete
            // 
            btnListToDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnListToDelete.Location = new Point(755, 224);
            btnListToDelete.Name = "btnListToDelete";
            btnListToDelete.Size = new Size(120, 33);
            btnListToDelete.TabIndex = 6;
            btnListToDelete.Text = "Create List...";
            btnListToDelete.UseVisualStyleBackColor = true;
            btnListToDelete.Click += btnListToDelete_Click;
            // 
            // lblItemCount
            // 
            lblItemCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblItemCount.AutoSize = true;
            lblItemCount.Location = new Point(755, 265);
            lblItemCount.Name = "lblItemCount";
            lblItemCount.Size = new Size(88, 15);
            lblItemCount.TabIndex = 7;
            lblItemCount.Text = "Items to delete:";
            // 
            // cbRemEmptyFolders
            // 
            cbRemEmptyFolders.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbRemEmptyFolders.AutoSize = true;
            cbRemEmptyFolders.Checked = true;
            cbRemEmptyFolders.CheckState = CheckState.Checked;
            cbRemEmptyFolders.Font = new Font("Segoe UI", 9F);
            cbRemEmptyFolders.Location = new Point(755, 289);
            cbRemEmptyFolders.Name = "cbRemEmptyFolders";
            cbRemEmptyFolders.Size = new Size(112, 19);
            cbRemEmptyFolders.TabIndex = 8;
            cbRemEmptyFolders.Text = "Lösche l. Ordner";
            cbRemEmptyFolders.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDelete.Enabled = false;
            btnDelete.Location = new Point(755, 376);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 42);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Ausführen...";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAbort
            // 
            btnAbort.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAbort.Location = new Point(755, 424);
            btnAbort.Name = "btnAbort";
            btnAbort.Size = new Size(120, 25);
            btnAbort.TabIndex = 10;
            btnAbort.Text = "Abbrechen";
            btnAbort.UseVisualStyleBackColor = true;
            btnAbort.Click += btnAbort_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 461);
            Controls.Add(btnAbort);
            Controls.Add(btnDelete);
            Controls.Add(cbRemEmptyFolders);
            Controls.Add(lblItemCount);
            Controls.Add(btnListToDelete);
            Controls.Add(label2);
            Controls.Add(clbExtensions);
            Controls.Add(dgvToDelete);
            Controls.Add(tbPath);
            Controls.Add(label1);
            Controls.Add(btnPathSelect);
            MinimumSize = new Size(840, 500);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvToDelete).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPathSelect;
        private Label label1;
        private TextBox tbPath;
        private DataGridView dgvToDelete;
        private CheckedListBox clbExtensions;
        private Label label2;
        private Button btnListToDelete;
        private DataGridViewTextBoxColumn Pfad;
        private Label lblItemCount;
        private CheckBox cbRemEmptyFolders;
        private Button btnDelete;
        private Button btnAbort;
    }
}
