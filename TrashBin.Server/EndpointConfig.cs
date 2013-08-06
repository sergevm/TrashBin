using System.Data.Entity;
using NServiceBus;
using TrashBin.Domain;

namespace TrashBin.Server
{
    /*
		This class configures this endpoint as a Server. More information about how to configure the NServiceBus host
		can be found here: http://nservicebus.com/GenericHost.aspx
	*/
	public class EndpointConfig : IConfigureThisEndpoint, AsA_Server, IWantToRunBeforeConfiguration
    {
	    public void Init()
	    {
	        using (var context = new TrashBinContext())
	        {
                context.Database.Initialize(false);
	        }
	    }
    }
}