namespace ConverterPNGToINC
{
    partial class MainForm
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
            this.OpenPngButton = new System.Windows.Forms.Button();
            this.OpenFolderButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // OpenPngButton
            // 
            this.OpenPngButton.Location = new System.Drawing.Point(12, 12);
            this.OpenPngButton.Name = "OpenPngButton";
            this.OpenPngButton.Size = new System.Drawing.Size(282, 61);
            this.OpenPngButton.TabIndex = 0;
            this.OpenPngButton.Text = "Открыть png файл";
            this.OpenPngButton.UseVisualStyleBackColor = true;
            this.OpenPngButton.Click += new System.EventHandler(this.OpenPngButton_Click);
            // 
            // OpenFolderButton
            // 
            this.OpenFolderButton.Location = new System.Drawing.Point(12, 86);
            this.OpenFolderButton.Name = "OpenFolderButton";
            this.OpenFolderButton.Size = new System.Drawing.Size(282, 61);
            this.OpenFolderButton.TabIndex = 1;
            this.OpenFolderButton.Text = "Открыть папку с png файлами";
            this.OpenFolderButton.UseVisualStyleBackColor = true;
            this.OpenFolderButton.Click += new System.EventHandler(this.OpenFolderButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 159);
            this.Controls.Add(this.OpenFolderButton);
            this.Controls.Add(this.OpenPngButton);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConverterPNGToINC";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;

        private System.Windows.Forms.OpenFileDialog openFileDialog1;

        private System.Windows.Forms.Button OpenFolderButton;

        private System.Windows.Forms.Button OpenPngButton;

        #endregion
    }
}