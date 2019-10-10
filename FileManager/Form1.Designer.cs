namespace FileManager
{
    partial class FileManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FilesFromA = new System.Windows.Forms.ListBox();
            this.ReadA = new System.Windows.Forms.Button();
            this.ReadB = new System.Windows.Forms.Button();
            this.FilesFromB = new System.Windows.Forms.ListBox();
            this.DeleteA = new System.Windows.Forms.Button();
            this.DeleteB = new System.Windows.Forms.Button();
            this.Duplicates = new System.Windows.Forms.ListBox();
            this.PathA = new System.Windows.Forms.TextBox();
            this.PathB = new System.Windows.Forms.TextBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.FindDupButton = new System.Windows.Forms.Button();
            this.FilesFromACount = new System.Windows.Forms.Label();
            this.FilesFromBCount = new System.Windows.Forms.Label();
            this.DuplicateCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FilesFromA
            // 
            this.FilesFromA.FormattingEnabled = true;
            this.FilesFromA.Location = new System.Drawing.Point(12, 68);
            this.FilesFromA.Name = "FilesFromA";
            this.FilesFromA.Size = new System.Drawing.Size(340, 173);
            this.FilesFromA.TabIndex = 0;
            // 
            // ReadA
            // 
            this.ReadA.Location = new System.Drawing.Point(12, 12);
            this.ReadA.Name = "ReadA";
            this.ReadA.Size = new System.Drawing.Size(100, 50);
            this.ReadA.TabIndex = 1;
            this.ReadA.Text = "Read files from directory A";
            this.ReadA.UseVisualStyleBackColor = true;
            this.ReadA.Click += new System.EventHandler(this.ReadA_Click);
            // 
            // ReadB
            // 
            this.ReadB.Location = new System.Drawing.Point(12, 247);
            this.ReadB.Name = "ReadB";
            this.ReadB.Size = new System.Drawing.Size(100, 50);
            this.ReadB.TabIndex = 2;
            this.ReadB.Text = "Read files from directory B";
            this.ReadB.UseVisualStyleBackColor = true;
            this.ReadB.Click += new System.EventHandler(this.ReadB_Click);
            // 
            // FilesFromB
            // 
            this.FilesFromB.FormattingEnabled = true;
            this.FilesFromB.Location = new System.Drawing.Point(12, 303);
            this.FilesFromB.Name = "FilesFromB";
            this.FilesFromB.Size = new System.Drawing.Size(340, 173);
            this.FilesFromB.TabIndex = 3;
            // 
            // DeleteA
            // 
            this.DeleteA.Enabled = false;
            this.DeleteA.Location = new System.Drawing.Point(358, 84);
            this.DeleteA.Name = "DeleteA";
            this.DeleteA.Size = new System.Drawing.Size(100, 50);
            this.DeleteA.TabIndex = 4;
            this.DeleteA.Text = "Delete duplicates from A";
            this.DeleteA.UseVisualStyleBackColor = true;
            this.DeleteA.Click += new System.EventHandler(this.DeleteA_Click);
            // 
            // DeleteB
            // 
            this.DeleteB.Enabled = false;
            this.DeleteB.Location = new System.Drawing.Point(358, 140);
            this.DeleteB.Name = "DeleteB";
            this.DeleteB.Size = new System.Drawing.Size(100, 50);
            this.DeleteB.TabIndex = 5;
            this.DeleteB.Text = "Delete duplicates from B";
            this.DeleteB.UseVisualStyleBackColor = true;
            this.DeleteB.Click += new System.EventHandler(this.DeleteB_Click);
            // 
            // Duplicates
            // 
            this.Duplicates.FormattingEnabled = true;
            this.Duplicates.Location = new System.Drawing.Point(464, 28);
            this.Duplicates.Name = "Duplicates";
            this.Duplicates.Size = new System.Drawing.Size(263, 446);
            this.Duplicates.TabIndex = 6;
            // 
            // PathA
            // 
            this.PathA.Location = new System.Drawing.Point(118, 12);
            this.PathA.Name = "PathA";
            this.PathA.Size = new System.Drawing.Size(234, 20);
            this.PathA.TabIndex = 7;
            // 
            // PathB
            // 
            this.PathB.Location = new System.Drawing.Point(118, 247);
            this.PathB.Name = "PathB";
            this.PathB.Size = new System.Drawing.Size(234, 20);
            this.PathB.TabIndex = 8;
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(358, 196);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(100, 50);
            this.ResetButton.TabIndex = 9;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // FindDupButton
            // 
            this.FindDupButton.Location = new System.Drawing.Point(358, 28);
            this.FindDupButton.Name = "FindDupButton";
            this.FindDupButton.Size = new System.Drawing.Size(100, 50);
            this.FindDupButton.TabIndex = 10;
            this.FindDupButton.Text = "Find Duplicates";
            this.FindDupButton.UseVisualStyleBackColor = true;
            this.FindDupButton.Click += new System.EventHandler(this.FindDupButton_Click);
            // 
            // FilesFromACount
            // 
            this.FilesFromACount.AutoSize = true;
            this.FilesFromACount.Location = new System.Drawing.Point(118, 47);
            this.FilesFromACount.Name = "FilesFromACount";
            this.FilesFromACount.Size = new System.Drawing.Size(0, 13);
            this.FilesFromACount.TabIndex = 11;
            // 
            // FilesFromBCount
            // 
            this.FilesFromBCount.AutoSize = true;
            this.FilesFromBCount.Location = new System.Drawing.Point(118, 284);
            this.FilesFromBCount.Name = "FilesFromBCount";
            this.FilesFromBCount.Size = new System.Drawing.Size(0, 13);
            this.FilesFromBCount.TabIndex = 12;
            // 
            // DuplicateCount
            // 
            this.DuplicateCount.AutoSize = true;
            this.DuplicateCount.Location = new System.Drawing.Point(423, 254);
            this.DuplicateCount.Name = "DuplicateCount";
            this.DuplicateCount.Size = new System.Drawing.Size(0, 13);
            this.DuplicateCount.TabIndex = 13;
            // 
            // FileManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 495);
            this.Controls.Add(this.DuplicateCount);
            this.Controls.Add(this.FilesFromBCount);
            this.Controls.Add(this.FilesFromACount);
            this.Controls.Add(this.FindDupButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.PathB);
            this.Controls.Add(this.PathA);
            this.Controls.Add(this.Duplicates);
            this.Controls.Add(this.DeleteB);
            this.Controls.Add(this.DeleteA);
            this.Controls.Add(this.FilesFromB);
            this.Controls.Add(this.ReadB);
            this.Controls.Add(this.ReadA);
            this.Controls.Add(this.FilesFromA);
            this.Name = "FileManager";
            this.Text = "File Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox FilesFromA;
        private System.Windows.Forms.Button ReadA;
        private System.Windows.Forms.Button ReadB;
        private System.Windows.Forms.ListBox FilesFromB;
        private System.Windows.Forms.Button DeleteA;
        private System.Windows.Forms.Button DeleteB;
        private System.Windows.Forms.ListBox Duplicates;
        private System.Windows.Forms.TextBox PathA;
        private System.Windows.Forms.TextBox PathB;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button FindDupButton;
        private System.Windows.Forms.Label FilesFromACount;
        private System.Windows.Forms.Label FilesFromBCount;
        private System.Windows.Forms.Label DuplicateCount;
    }
}

