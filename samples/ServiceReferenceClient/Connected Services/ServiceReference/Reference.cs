﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReference
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ComplexModelInput", Namespace="http://schemas.datacontract.org/2004/07/Models")]
    public partial class ComplexModelInput : object
    {
        
        private ServiceReference.ComplexObject[] ComplexListPropertyField;
        
        private System.DateTimeOffset DateTimeOffsetPropertyField;
        
        private ServiceReference.BaseObject[] DerivedObjectsField;
        
        private int IntPropertyField;
        
        private string[] ListPropertyField;
        
        private string StringPropertyField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference.ComplexObject[] ComplexListProperty
        {
            get
            {
                return this.ComplexListPropertyField;
            }
            set
            {
                this.ComplexListPropertyField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTimeOffset DateTimeOffsetProperty
        {
            get
            {
                return this.DateTimeOffsetPropertyField;
            }
            set
            {
                this.DateTimeOffsetPropertyField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference.BaseObject[] DerivedObjects
        {
            get
            {
                return this.DerivedObjectsField;
            }
            set
            {
                this.DerivedObjectsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IntProperty
        {
            get
            {
                return this.IntPropertyField;
            }
            set
            {
                this.IntPropertyField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] ListProperty
        {
            get
            {
                return this.ListPropertyField;
            }
            set
            {
                this.ListPropertyField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringProperty
        {
            get
            {
                return this.StringPropertyField;
            }
            set
            {
                this.StringPropertyField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ComplexObject", Namespace="http://schemas.datacontract.org/2004/07/Models")]
    public partial class ComplexObject : object
    {
        
        private int IntPropertyField;
        
        private string StringPropertyField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IntProperty
        {
            get
            {
                return this.IntPropertyField;
            }
            set
            {
                this.IntPropertyField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringProperty
        {
            get
            {
                return this.StringPropertyField;
            }
            set
            {
                this.StringPropertyField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BaseObject", Namespace="http://schemas.datacontract.org/2004/07/Models")]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ServiceReference.DerivedObject))]
    public partial class BaseObject : object
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DerivedObject", Namespace="http://schemas.datacontract.org/2004/07/Models")]
    public partial class DerivedObject : ServiceReference.BaseObject
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ComplexModelResponse", Namespace="http://schemas.datacontract.org/2004/07/Models")]
    public partial class ComplexModelResponse : object
    {
        
        private System.DateTimeOffset DateTimeOffsetPropertyField;
        
        private float FloatPropertyField;
        
        private string[] ListPropertyField;
        
        private string StringPropertyField;
        
        private ServiceReference.TestEnum TestEnumField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTimeOffset DateTimeOffsetProperty
        {
            get
            {
                return this.DateTimeOffsetPropertyField;
            }
            set
            {
                this.DateTimeOffsetPropertyField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float FloatProperty
        {
            get
            {
                return this.FloatPropertyField;
            }
            set
            {
                this.FloatPropertyField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] ListProperty
        {
            get
            {
                return this.ListPropertyField;
            }
            set
            {
                this.ListPropertyField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringProperty
        {
            get
            {
                return this.StringPropertyField;
            }
            set
            {
                this.StringPropertyField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public ServiceReference.TestEnum TestEnum
        {
            get
            {
                return this.TestEnumField;
            }
            set
            {
                this.TestEnumField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TestEnum", Namespace="http://schemas.datacontract.org/2004/07/Models")]
    public enum TestEnum : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        One = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Two = 1,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ComplexReturnModel", Namespace="http://schemas.datacontract.org/2004/07/Models")]
    public partial class ComplexReturnModel : object
    {
        
        private int IdField;
        
        private string NameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.ISampleService")]
    public interface ISampleService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISampleService/Ping", ReplyAction="http://tempuri.org/ISampleService/PingResponse")]
        string Ping(string s);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISampleService/Ping", ReplyAction="http://tempuri.org/ISampleService/PingResponse")]
        System.Threading.Tasks.Task<string> PingAsync(string s);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISampleService/PingComplexModel", ReplyAction="http://tempuri.org/ISampleService/PingComplexModelResponse")]
        ServiceReference.ComplexModelResponse PingComplexModel(ServiceReference.ComplexModelInput inputModel);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISampleService/PingComplexModel", ReplyAction="http://tempuri.org/ISampleService/PingComplexModelResponse")]
        System.Threading.Tasks.Task<ServiceReference.ComplexModelResponse> PingComplexModelAsync(ServiceReference.ComplexModelInput inputModel);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISampleService/IntArray", ReplyAction="http://tempuri.org/ISampleService/IntArrayResponse")]
        int[] IntArray();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISampleService/IntArray", ReplyAction="http://tempuri.org/ISampleService/IntArrayResponse")]
        System.Threading.Tasks.Task<int[]> IntArrayAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISampleService/ComplexReturnModel", ReplyAction="http://tempuri.org/ISampleService/ComplexReturnModelResponse")]
        ServiceReference.ComplexReturnModel[] ComplexReturnModel();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISampleService/ComplexReturnModel", ReplyAction="http://tempuri.org/ISampleService/ComplexReturnModelResponse")]
        System.Threading.Tasks.Task<ServiceReference.ComplexReturnModel[]> ComplexReturnModelAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISampleService/VoidMethod", ReplyAction="http://tempuri.org/ISampleService/VoidMethodResponse")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="s")]
        string VoidMethod();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISampleService/VoidMethod", ReplyAction="http://tempuri.org/ISampleService/VoidMethodResponse")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="s")]
        System.Threading.Tasks.Task<string> VoidMethodAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISampleService/AsyncMethod", ReplyAction="http://tempuri.org/ISampleService/AsyncMethodResponse")]
        int AsyncMethod();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISampleService/AsyncMethod", ReplyAction="http://tempuri.org/ISampleService/AsyncMethodResponse")]
        System.Threading.Tasks.Task<int> AsyncMethodAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISampleService/NullableMethod", ReplyAction="http://tempuri.org/ISampleService/NullableMethodResponse")]
        System.Nullable<int> NullableMethod(System.Nullable<bool> arg);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISampleService/NullableMethod", ReplyAction="http://tempuri.org/ISampleService/NullableMethodResponse")]
        System.Threading.Tasks.Task<System.Nullable<int>> NullableMethodAsync(System.Nullable<bool> arg);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISampleService/XmlMethod", ReplyAction="http://tempuri.org/ISampleService/XmlMethodResponse")]
        void XmlMethod(System.Xml.XmlElement xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISampleService/XmlMethod", ReplyAction="http://tempuri.org/ISampleService/XmlMethodResponse")]
        System.Threading.Tasks.Task XmlMethodAsync(System.Xml.XmlElement xml);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    public interface ISampleServiceChannel : ServiceReference.ISampleService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    public partial class SampleServiceClient : System.ServiceModel.ClientBase<ServiceReference.ISampleService>, ServiceReference.ISampleService
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public SampleServiceClient() : 
                base(SampleServiceClient.GetDefaultBinding(), SampleServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_ISampleService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SampleServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(SampleServiceClient.GetBindingForEndpoint(endpointConfiguration), SampleServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SampleServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(SampleServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SampleServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(SampleServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SampleServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public string Ping(string s)
        {
            return base.Channel.Ping(s);
        }
        
        public System.Threading.Tasks.Task<string> PingAsync(string s)
        {
            return base.Channel.PingAsync(s);
        }
        
        public ServiceReference.ComplexModelResponse PingComplexModel(ServiceReference.ComplexModelInput inputModel)
        {
            return base.Channel.PingComplexModel(inputModel);
        }
        
        public System.Threading.Tasks.Task<ServiceReference.ComplexModelResponse> PingComplexModelAsync(ServiceReference.ComplexModelInput inputModel)
        {
            return base.Channel.PingComplexModelAsync(inputModel);
        }
        
        public int[] IntArray()
        {
            return base.Channel.IntArray();
        }
        
        public System.Threading.Tasks.Task<int[]> IntArrayAsync()
        {
            return base.Channel.IntArrayAsync();
        }
        
        public ServiceReference.ComplexReturnModel[] ComplexReturnModel()
        {
            return base.Channel.ComplexReturnModel();
        }
        
        public System.Threading.Tasks.Task<ServiceReference.ComplexReturnModel[]> ComplexReturnModelAsync()
        {
            return base.Channel.ComplexReturnModelAsync();
        }
        
        public string VoidMethod()
        {
            return base.Channel.VoidMethod();
        }
        
        public System.Threading.Tasks.Task<string> VoidMethodAsync()
        {
            return base.Channel.VoidMethodAsync();
        }
        
        public int AsyncMethod()
        {
            return base.Channel.AsyncMethod();
        }
        
        public System.Threading.Tasks.Task<int> AsyncMethodAsync()
        {
            return base.Channel.AsyncMethodAsync();
        }
        
        public System.Nullable<int> NullableMethod(System.Nullable<bool> arg)
        {
            return base.Channel.NullableMethod(arg);
        }
        
        public System.Threading.Tasks.Task<System.Nullable<int>> NullableMethodAsync(System.Nullable<bool> arg)
        {
            return base.Channel.NullableMethodAsync(arg);
        }
        
        public void XmlMethod(System.Xml.XmlElement xml)
        {
            base.Channel.XmlMethod(xml);
        }
        
        public System.Threading.Tasks.Task XmlMethodAsync(System.Xml.XmlElement xml)
        {
            return base.Channel.XmlMethodAsync(xml);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ISampleService))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ISampleService))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:5050/Service.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return SampleServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_ISampleService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return SampleServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_ISampleService);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_ISampleService,
        }
    }
}
