using FileManager.EventComponents;
using System;
using System.Collections.Generic;

namespace FileManager.Interfaces
{
    public interface IFileRenameService
    {
        event EventHandler<FileRenameErrorEventArgs> FileRenameError;

        string[] RenameInOrder(IEnumerable<string> files, string commonName);
    }
}