using FileManager.EventComponents;
using FileManager.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FileManager.Services
{
    public class FileRenameService : IFileRenameService
    {
        public event EventHandler<FileRenameErrorEventArgs> FileRenameError;

        public string[] RenameInOrder(IEnumerable<string> files, string commonName)
        {
            if (commonName == null) throw new ArgumentNullException(nameof(commonName));
            if (String.IsNullOrWhiteSpace(commonName)) throw new ArgumentException("Invalid file name", nameof(commonName));
            string[] renamedFiles = new string[files.Count()];
            int index = 0;
            int numberInOrder = 1;
            foreach (string file in files)
            {
                renamedFiles[index++] = TryToRenameFile(file, commonName, numberInOrder++);
            }
            return renamedFiles;
        }

        private void NotifyAboutAnError(FileRenameErrorEventArgs e)
        {
            EventHandler<FileRenameErrorEventArgs> temp = FileRenameError;
            temp?.Invoke(this, e);
        }

        private RenamingResult RenameFile(string oldFileName, string newFileName)
        {
            if (oldFileName == newFileName) return RenamingResult.Success;
            if (File.Exists(newFileName)) return RenamingResult.Failure;
            try
            {
                File.Move(oldFileName, newFileName);
            }
            catch (Exception ex)
            {
                NotifyAboutAnError(new FileRenameErrorEventArgs(oldFileName, newFileName, ex.Message));
                return RenamingResult.Error;
            }
            return RenamingResult.Success;
        }

        private string TryToRenameFile(string fileName, string commonName, int numberInOrder)
        {
            FileInfo fileInfo = new FileInfo(fileName);
            while (true)
            {
                string newFileName = Path.Combine(fileInfo.DirectoryName, commonName + numberInOrder++ + fileInfo.Extension);
                RenamingResult renamingResult = RenameFile(fileName, newFileName);
                if (renamingResult == RenamingResult.Success) return newFileName;
                if (renamingResult == RenamingResult.Error) return fileName;
            }
        }

        private enum RenamingResult
        {
            Success = 1,
            Failure,
            Error
        }
    }
}