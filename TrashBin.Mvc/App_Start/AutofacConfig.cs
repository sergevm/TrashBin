using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using NServiceBus;

namespace TrashBin.Mvc.App_Start
{
    public class AutofacConfig 
    {
        public static void Configure()
        {
            var builder = new ContainerBuilder();
            
            builder.RegisterModule<AutofacBootstrapModule>();
            
            var container = builder.Build();

            NServiceBus.Configure.With().AutofacBuilder(container)
                .UseTransport<Msmq>()
                .UnicastBus()
                .LoadMessageHandlers()
                .CreateBus()
                .Start(() => NServiceBus.Configure.Instance.ForInstallationOn<NServiceBus.Installation.Environments.Windows>().Install());

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}