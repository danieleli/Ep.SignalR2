using System;
using Ninject;
using PayrollClient.DataServices;
using PayrollClient.Notifications;

namespace PayrollClient.Ninject
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

            
            k.Bind<IPayrollBatchService>() .To<PayrollBatchService>();
            k.Bind<IBatchUpdatedNotifier>().ToProvider(new NotifierProvider());

            return k;
        }

    }
}