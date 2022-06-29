using Ninject;
using Ninject.Modules;

namespace FileManager.Infrastructure
{
    public class CompositionRoot
    {
        private readonly IKernel _ninjectKernel = new StandardKernel();

        public void AddModule(INinjectModule module)
        {
            _ninjectKernel.Load(module);
        }

        public T Get<T>()
        {
            return _ninjectKernel.Get<T>();
        }
    }
}