using FileManager.Interfaces;
using FileManager.Services;
using Ninject.Modules;

namespace FileManager.Infrastructure
{
    public class ServicesModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IFileOpenService>().To<FileOpenService>();
            Bind<IFileRenameService>().To<FileRenameService>();
        }
    }
}