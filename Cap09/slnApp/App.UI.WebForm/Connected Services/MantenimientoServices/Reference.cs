﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace App.UI.WebForm.MantenimientoServices {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MantenimientoServices.IMantenimientosServices")]
    public interface IMantenimientosServices {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMantenimientosServices/GetArtistAll", ReplyAction="http://tempuri.org/IMantenimientosServices/GetArtistAllResponse")]
        System.Collections.Generic.List<App.Entities.Base.Artist> GetArtistAll(string nombre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMantenimientosServices/GetArtistAll", ReplyAction="http://tempuri.org/IMantenimientosServices/GetArtistAllResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<App.Entities.Base.Artist>> GetArtistAllAsync(string nombre);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMantenimientosServicesChannel : App.UI.WebForm.MantenimientoServices.IMantenimientosServices, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MantenimientosServicesClient : System.ServiceModel.ClientBase<App.UI.WebForm.MantenimientoServices.IMantenimientosServices>, App.UI.WebForm.MantenimientoServices.IMantenimientosServices {
        
        public MantenimientosServicesClient() {
        }
        
        public MantenimientosServicesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MantenimientosServicesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MantenimientosServicesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MantenimientosServicesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<App.Entities.Base.Artist> GetArtistAll(string nombre) {
            return base.Channel.GetArtistAll(nombre);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<App.Entities.Base.Artist>> GetArtistAllAsync(string nombre) {
            return base.Channel.GetArtistAllAsync(nombre);
        }
    }
}
