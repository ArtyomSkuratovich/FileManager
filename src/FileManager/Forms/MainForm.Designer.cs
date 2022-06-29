namespace FileManager.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.fileNamesListBox = new System.Windows.Forms.ListBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.separatorLabel = new System.Windows.Forms.Label();
            this.separatorTextBox = new System.Windows.Forms.TextBox();
            this.renameButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.selectFilesButton = new System.Windows.Forms.Button();
            this.openFileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fileNamesListBox
            // 
            this.fileNamesListBox.FormattingEnabled = true;
            this.fileNamesListBox.HorizontalScrollbar = true;
            this.fileNamesListBox.Location = new System.Drawing.Point(13, 13);
            this.fileNamesListBox.Name = "fileNamesListBox";
            this.fileNamesListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.fileNamesListBox.Size = new System.Drawing.Size(400, 290);
            this.fileNamesListBox.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(429, 26);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(85, 16);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Название:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(432, 45);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(236, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // separatorLabel
            // 
            this.separatorLabel.AutoSize = true;
            this.separatorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.separatorLabel.Location = new System.Drawing.Point(429, 81);
            this.separatorLabel.Name = "separatorLabel";
            this.separatorLabel.Size = new System.Drawing.Size(109, 16);
            this.separatorLabel.TabIndex = 3;
            this.separatorLabel.Text = "Разделитель:";
            // 
            // separatorTextBox
            // 
            this.separatorTextBox.Location = new System.Drawing.Point(432, 100);
            this.separatorTextBox.Name = "separatorTextBox";
            this.separatorTextBox.Size = new System.Drawing.Size(236, 20);
            this.separatorTextBox.TabIndex = 4;
            this.separatorTextBox.Text = "_";
            // 
            // renameButton
            // 
            this.renameButton.Location = new System.Drawing.Point(432, 148);
            this.renameButton.Name = "renameButton";
            this.renameButton.Size = new System.Drawing.Size(100, 30);
            this.renameButton.TabIndex = 5;
            this.renameButton.Text = "Переименовать";
            this.renameButton.UseVisualStyleBackColor = true;
            this.renameButton.Click += new System.EventHandler(this.RenameClick);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(432, 184);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(100, 30);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Очистить поле";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearClick);
            // 
            // selectFilesButton
            // 
            this.selectFilesButton.Location = new System.Drawing.Point(538, 148);
            this.selectFilesButton.Name = "selectFilesButton";
            this.selectFilesButton.Size = new System.Drawing.Size(130, 30);
            this.selectFilesButton.TabIndex = 7;
            this.selectFilesButton.Text = "Выбрать файлы";
            this.selectFilesButton.UseVisualStyleBackColor = true;
            this.selectFilesButton.Click += new System.EventHandler(this.SelectFilesButton);
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(538, 184);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(130, 30);
            this.openFileButton.TabIndex = 8;
            this.openFileButton.Text = "Открыть файл";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.OpenFileClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 317);
            this.Controls.Add(this.openFileButton);
            this.Controls.Add(this.selectFilesButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.renameButton);
            this.Controls.Add(this.separatorTextBox);
            this.Controls.Add(this.separatorLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.fileNamesListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "File Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox fileNamesListBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label separatorLabel;
        private System.Windows.Forms.TextBox separatorTextBox;
        private System.Windows.Forms.Button renameButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button selectFilesButton;
        private System.Windows.Forms.Button openFileButton;
    }
}