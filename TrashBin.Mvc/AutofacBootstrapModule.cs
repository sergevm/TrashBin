using Autofac;
using Autofac.Integration.Mvc;
using TrashBin.Domain;
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
            builder.RegisterAssemblyTypes(typeof(MvcApplication).Assembly).InNamespaceOf<ProjectService>()
                   .Where(t => t.Name.EndsWith("Service"))
                   .AsImplementedInterfaces();
            
            // Register the controllers in the assembly
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
        }
    }
}