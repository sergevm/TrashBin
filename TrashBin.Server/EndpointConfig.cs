using Autofac;
using NServiceBus;

namespace TrashBin.Server
{
    [EndpointName("TrashBin.Commands")]
	public class EndpointConfig : IConfigureThisEndpoint, IWantCustomInitialization, AsA_Publisher
	{
	    private static ILifetimeScope container;

	    void IWantCustomInitialization.Init()
	    {
            var containerBuilder = new ContainerBuilder();

            containerBuilder.RegisterAssemblyTypes(GetType().Assembly)
                            .Where(type => type.Name.EndsWith("Handler"))
                            .AsImplementedInterfaces().AsSelf()
                            .InstancePerDependency();

            container = containerBuilder.Build();

            Configure.With().AutofacBuilder(container)
                .UseTransport<Msmq>()
                .UnicastBus();
        }
    }
}