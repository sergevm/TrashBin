using Autofac;
using Autofac.Integration.Mvc;
using NServiceBus;
using TrashBin.Domain;
using TrashBin.Mvc.Hubs;
using TrashBin.Mvc.Services;

namespace TrashBin.Mvc
{
    public class AutofacBootstrapModule : Module 
    {
        protected override void Load(ContainerBuilder builder)
        {
            // One data context per request
            builder.RegisterType<TrashBinContext>().InstancePerHttpRequest();

            // Auto resolve all service type classes
            builder.RegisterAssemblyTypes(typeof(MvcApplication).Assembly)
                .InNamespaceOf<ProjectService>()
                .AsImplementedInterfaces()
                .InstancePerDependency();

            // Resolve NServiceBus message handlers
            builder.RegisterAssemblyTypes(typeof(MvcApplication).Assembly)
                .Where(t => t.IsClosedTypeOf(typeof(IHandleMessages<>)))
                .AsSelf()
                .InstancePerDependency();

            builder.RegisterType<AsyncWorkNotificationHub>().SingleInstance();

            // Register the controllers in the assembly
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
        }
    }
}