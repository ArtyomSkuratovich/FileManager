using System;

namespace FileManager.EventComponents
{
    public class FileRenameErrorEventArgs : EventArgs
    {
        public FileRenameErrorEventArgs(string fileName, string newFileName, string message)
        {
            FileName = fileName;
            NewFileName = newFileName;
            Message = message;
        }

        public string FileName { get; }

        public string NewFileName { get; }

        public string Message { get; }
    }
}