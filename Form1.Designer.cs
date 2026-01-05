namespace Vsql
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
            FileLabel = new Label();
            ContentOutputBox = new TextBox();
            SearchFile = new Button();
            FileSavedToDir = new Button();
            SaveFile = new Button();
            SuspendLayout();
            // 
            // FileLabel
            // 
            FileLabel.AutoSize = true;
            FileLabel.Location = new Point(19, 14);
            FileLabel.Name = "FileLabel";
            FileLabel.Size = new Size(58, 15);
            FileLabel.TabIndex = 0;
            FileLabel.Text = "File name";
            // 
            // ContentOutputBox
            // 
            ContentOutputBox.Location = new Point(19, 89);
            ContentOutputBox.Multiline = true;
            ContentOutputBox.Name = "ContentOutputBox";
            ContentOutputBox.Size = new Size(328, 349);
            ContentOutputBox.TabIndex = 2;
            // 
            // SearchFile
            // 
            SearchFile.Location = new Point(19, 32);
            SearchFile.Name = "SearchFile";
            SearchFile.Size = new Size(115, 34);
            SearchFile.TabIndex = 3;
            SearchFile.Text = "Browse";
            SearchFile.UseVisualStyleBackColor = true;
            SearchFile.Click += SearchFile_Click;
            // 
            // FileSavedToDir
            // 
            FileSavedToDir.Location = new Point(465, 32);
            FileSavedToDir.Name = "FileSavedToDir";
            FileSavedToDir.Size = new Size(120, 95);
            FileSavedToDir.TabIndex = 4;
            FileSavedToDir.Text = "Saved files";
            FileSavedToDir.UseVisualStyleBackColor = true;
            FileSavedToDir.Click += FileSavedToDir_Click;
            // 
            // SaveFile
            // 
            SaveFile.Location = new Point(19, 444);
            SaveFile.Name = "SaveFile";
            SaveFile.Size = new Size(100, 26);
            SaveFile.TabIndex = 5;
            SaveFile.Text = "Save";
            SaveFile.UseVisualStyleBackColor = true;
            SaveFile.Click += SaveFile_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 641);
            Controls.Add(SaveFile);
            Controls.Add(FileSavedToDir);
            Controls.Add(SearchFile);
            Controls.Add(ContentOutputBox);
            Controls.Add(FileLabel);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FileLabel;
        private TextBox ContentOutputBox;
        private Button SearchFile;
        private Button FileSavedToDir;
        private Button SaveFile;
    }
}
