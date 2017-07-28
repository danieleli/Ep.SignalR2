using Ninject;
using SignalR.Server.Hubs;

namespace SignalR.Server.Host.DependencyInjection
{
    public class KernelFactory
    {
        private static StandardKernel _kernel;

        public static StandardKernel GetKernel()
        {
            _kernel = _kernel ?? CreateKernel();

            return _kernel;
        }

        private static StandardKernel CreateKernel()
        {
            var k = new StandardKernel();

            k.Bind<IHubLogger>().To<HubLogger>().InSingletonScope();
            k.Bind<MainForm>().To<MainForm>();

            return k;
        }

    }
}