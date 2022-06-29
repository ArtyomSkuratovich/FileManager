using FileManager.EventComponents;
using FileManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FileManager.Forms
{
    public partial class MainForm : Form
    {
        private readonly IFileOpenService _fileOpenService;
        private readonly IFileRenameService _fileRenameService;

        public MainForm(IFileOpenService fileOpenService, IFileRenameService fileRenameService)
        {
            _fileOpenService = fileOpenService;
            _fileRenameService = fileRenameService;
            _fileRenameService.FileRenameError += ErrorMessage;
            InitializeComponent();
        }

        private void RenameClick(object sender, EventArgs e)
        {
            if (fileNamesListBox.Items.Count == 0)
            {
                MessageBox.Show("No images selected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!CheckNewName()) return;
            if (fileNamesListBox.SelectedItems.Count != 0) RenameSelectedFiles();
            else RenameAllFiles();
        }

        private void ClearClick(object sender, EventArgs e)
        {
            fileNamesListBox.Items.Clear();
        }

        private void SelectFilesButton(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Multiselect = true,
                Filter = "Images(*.bmp;*.png;*.jpg;*.jpeg;*.gif)|*.bmp;*.png;*.jpg;*.jpeg;*.gif|All files(*.*)|*.*"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] files = openFileDialog.FileNames;
                fileNamesListBox.Items.Clear();
                fileNamesListBox.Items.AddRange(files);
            }
        }

        private void OpenFileClick(object sender, EventArgs e)
        {
            if (fileNamesListBox.SelectedItems.Count != 1)
            {
                MessageBox.Show("You need to select one image", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                _fileOpenService.Open(fileNamesListBox.SelectedItem.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RenameSelectedFiles()
        {
            IEnumerable<string> files = fileNamesListBox.SelectedItems.Cast<string>();
            string[] renamedFiles = _fileRenameService.RenameInOrder(files, nameTextBox.Text + separatorTextBox.Text);
            int index = 0;
            while (fileNamesListBox.SelectedIndices.Count > 0)
            {
                int selectedIndex = fileNamesListBox.SelectedIndex;
                fileNamesListBox.Items.RemoveAt(selectedIndex);
                fileNamesListBox.Items.Insert(selectedIndex, renamedFiles[index++]);
            }
        }

        private void RenameAllFiles()
        {
            IEnumerable<string> files = fileNamesListBox.Items.Cast<string>();
            string[] renamedFiles = _fileRenameService.RenameInOrder(files, nameTextBox.Text + separatorTextBox.Text);
            fileNamesListBox.Items.Clear();
            fileNamesListBox.Items.AddRange(renamedFiles);
        }

        private bool CheckNewName()
        {
            if (nameTextBox.Text.Length == 0)
            {
                MessageBox.Show("The new name of the images is not specified", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void ErrorMessage(object sender, FileRenameErrorEventArgs e)
        {
            string fullMessage = String.Format("File {0} could not be renamed to {1}. Error message: {2}", e.FileName, e.NewFileName, e.Message);
            MessageBox.Show(fullMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}