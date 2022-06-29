using FileManager.Interfaces;
using System.Diagnostics;

namespace FileManager.Services
{
    public class FileOpenService : IFileOpenService
    {
        public void Open(string filePath)
        {
            Process.Start(filePath);
        }
    }
}