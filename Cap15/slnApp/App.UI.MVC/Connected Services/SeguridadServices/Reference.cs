﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace App.UI.MVC.SeguridadServices {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SeguridadServices.ISeguridadServices")]
    public interface ISeguridadServices {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISeguridadServices/ValidarAcceso", ReplyAction="http://tempuri.org/ISeguridadServices/ValidarAccesoResponse")]
        App.Entities.Base.Usuario ValidarAcceso(string login, string clave);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISeguridadServices/ValidarAcceso", ReplyAction="http://tempuri.org/ISeguridadServices/ValidarAccesoResponse")]
        System.Threading.Tasks.Task<App.Entities.Base.Usuario> ValidarAccesoAsync(string login, string clave);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISeguridadServicesChannel : App.UI.MVC.SeguridadServices.ISeguridadServices, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SeguridadServicesClient : System.ServiceModel.ClientBase<App.UI.MVC.SeguridadServices.ISeguridadServices>, App.UI.MVC.SeguridadServices.ISeguridadServices {
        
        public SeguridadServicesClient() {
        }
        
        public SeguridadServicesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SeguridadServicesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SeguridadServicesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SeguridadServicesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public App.Entities.Base.Usuario ValidarAcceso(string login, string clave) {
            return base.Channel.ValidarAcceso(login, clave);
        }
        
        public System.Threading.Tasks.Task<App.Entities.Base.Usuario> ValidarAccesoAsync(string login, string clave) {
            return base.Channel.ValidarAccesoAsync(login, clave);
        }
    }
}
