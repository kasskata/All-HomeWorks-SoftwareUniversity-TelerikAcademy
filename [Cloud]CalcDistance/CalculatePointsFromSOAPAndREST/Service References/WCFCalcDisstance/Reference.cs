﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CalculatePointsFromSOAPAndREST.WCFCalcDisstance {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Point", Namespace="http://schemas.datacontract.org/2004/07/CalcDistance")]
    [System.SerializableAttribute()]
    public partial class Point : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double XField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double YField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double X {
            get {
                return this.XField;
            }
            set {
                if ((this.XField.Equals(value) != true)) {
                    this.XField = value;
                    this.RaisePropertyChanged("X");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Y {
            get {
                return this.YField;
            }
            set {
                if ((this.YField.Equals(value) != true)) {
                    this.YField = value;
                    this.RaisePropertyChanged("Y");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WCFCalcDisstance.ICalcultor")]
    public interface ICalcultor {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalcultor/CalcDistance", ReplyAction="http://tempuri.org/ICalcultor/CalcDistanceResponse")]
        double CalcDistance(CalculatePointsFromSOAPAndREST.WCFCalcDisstance.Point first, CalculatePointsFromSOAPAndREST.WCFCalcDisstance.Point second);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalcultor/CalcDistance", ReplyAction="http://tempuri.org/ICalcultor/CalcDistanceResponse")]
        System.Threading.Tasks.Task<double> CalcDistanceAsync(CalculatePointsFromSOAPAndREST.WCFCalcDisstance.Point first, CalculatePointsFromSOAPAndREST.WCFCalcDisstance.Point second);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalcultorChannel : CalculatePointsFromSOAPAndREST.WCFCalcDisstance.ICalcultor, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalcultorClient : System.ServiceModel.ClientBase<CalculatePointsFromSOAPAndREST.WCFCalcDisstance.ICalcultor>, CalculatePointsFromSOAPAndREST.WCFCalcDisstance.ICalcultor {
        
        public CalcultorClient() {
        }
        
        public CalcultorClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalcultorClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalcultorClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalcultorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double CalcDistance(CalculatePointsFromSOAPAndREST.WCFCalcDisstance.Point first, CalculatePointsFromSOAPAndREST.WCFCalcDisstance.Point second) {
            return base.Channel.CalcDistance(first, second);
        }
        
        public System.Threading.Tasks.Task<double> CalcDistanceAsync(CalculatePointsFromSOAPAndREST.WCFCalcDisstance.Point first, CalculatePointsFromSOAPAndREST.WCFCalcDisstance.Point second) {
            return base.Channel.CalcDistanceAsync(first, second);
        }
    }
}