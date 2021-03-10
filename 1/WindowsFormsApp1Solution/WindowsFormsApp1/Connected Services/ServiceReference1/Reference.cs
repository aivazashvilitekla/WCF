﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Customers", Namespace="http://schemas.datacontract.org/2004/07/WcfService1")]
    [System.SerializableAttribute()]
    public partial class Customers : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CityCField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CountryCField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FnameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LnameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneCField;
        
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
        public string CityC {
            get {
                return this.CityCField;
            }
            set {
                if ((object.ReferenceEquals(this.CityCField, value) != true)) {
                    this.CityCField = value;
                    this.RaisePropertyChanged("CityC");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CountryC {
            get {
                return this.CountryCField;
            }
            set {
                if ((object.ReferenceEquals(this.CountryCField, value) != true)) {
                    this.CountryCField = value;
                    this.RaisePropertyChanged("CountryC");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Fname {
            get {
                return this.FnameField;
            }
            set {
                if ((object.ReferenceEquals(this.FnameField, value) != true)) {
                    this.FnameField = value;
                    this.RaisePropertyChanged("Fname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Lname {
            get {
                return this.LnameField;
            }
            set {
                if ((object.ReferenceEquals(this.LnameField, value) != true)) {
                    this.LnameField = value;
                    this.RaisePropertyChanged("Lname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PhoneC {
            get {
                return this.PhoneCField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneCField, value) != true)) {
                    this.PhoneCField = value;
                    this.RaisePropertyChanged("PhoneC");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetCustomer", ReplyAction="http://tempuri.org/IService1/GetCustomerResponse")]
        WindowsFormsApp1.ServiceReference1.Customers GetCustomer(int customerId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetCustomer", ReplyAction="http://tempuri.org/IService1/GetCustomerResponse")]
        System.Threading.Tasks.Task<WindowsFormsApp1.ServiceReference1.Customers> GetCustomerAsync(int customerId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllCustomers", ReplyAction="http://tempuri.org/IService1/GetAllCustomersResponse")]
        WindowsFormsApp1.ServiceReference1.Customers[] GetAllCustomers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllCustomers", ReplyAction="http://tempuri.org/IService1/GetAllCustomersResponse")]
        System.Threading.Tasks.Task<WindowsFormsApp1.ServiceReference1.Customers[]> GetAllCustomersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddCustomer", ReplyAction="http://tempuri.org/IService1/AddCustomerResponse")]
        void AddCustomer(string fname, string lname, string city, string country, string phone);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddCustomer", ReplyAction="http://tempuri.org/IService1/AddCustomerResponse")]
        System.Threading.Tasks.Task AddCustomerAsync(string fname, string lname, string city, string country, string phone);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteCustomer", ReplyAction="http://tempuri.org/IService1/DeleteCustomerResponse")]
        void DeleteCustomer(int customerId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteCustomer", ReplyAction="http://tempuri.org/IService1/DeleteCustomerResponse")]
        System.Threading.Tasks.Task DeleteCustomerAsync(int customerId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WindowsFormsApp1.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WindowsFormsApp1.ServiceReference1.IService1>, WindowsFormsApp1.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WindowsFormsApp1.ServiceReference1.Customers GetCustomer(int customerId) {
            return base.Channel.GetCustomer(customerId);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsApp1.ServiceReference1.Customers> GetCustomerAsync(int customerId) {
            return base.Channel.GetCustomerAsync(customerId);
        }
        
        public WindowsFormsApp1.ServiceReference1.Customers[] GetAllCustomers() {
            return base.Channel.GetAllCustomers();
        }
        
        public System.Threading.Tasks.Task<WindowsFormsApp1.ServiceReference1.Customers[]> GetAllCustomersAsync() {
            return base.Channel.GetAllCustomersAsync();
        }
        
        public void AddCustomer(string fname, string lname, string city, string country, string phone) {
            base.Channel.AddCustomer(fname, lname, city, country, phone);
        }
        
        public System.Threading.Tasks.Task AddCustomerAsync(string fname, string lname, string city, string country, string phone) {
            return base.Channel.AddCustomerAsync(fname, lname, city, country, phone);
        }
        
        public void DeleteCustomer(int customerId) {
            base.Channel.DeleteCustomer(customerId);
        }
        
        public System.Threading.Tasks.Task DeleteCustomerAsync(int customerId) {
            return base.Channel.DeleteCustomerAsync(customerId);
        }
    }
}