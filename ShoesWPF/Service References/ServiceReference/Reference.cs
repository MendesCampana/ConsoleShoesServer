﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShoesWPF.ServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FactoryDataService", Namespace="http://schemas.datacontract.org/2004/07/ConsoleShoesServer.ShopDataService")]
    [System.SerializableAttribute()]
    public partial class FactoryDataService : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ShoesDataService", Namespace="http://schemas.datacontract.org/2004/07/ConsoleShoesServer.ShopDataService")]
    [System.SerializableAttribute()]
    public partial class ShoesDataService : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ShoesWPF.ServiceReference.AgeStatusDataService AgeDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AmountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ShoesWPF.ServiceReference.GenderDataService GenderDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ImagePathField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal IncomePriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ShoesWPF.ServiceReference.FactoryDataService ManufacturerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ModelNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ShoesWPF.ServiceReference.SizeDataService ModelSizeField;
        
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
        public ShoesWPF.ServiceReference.AgeStatusDataService AgeData {
            get {
                return this.AgeDataField;
            }
            set {
                if ((object.ReferenceEquals(this.AgeDataField, value) != true)) {
                    this.AgeDataField = value;
                    this.RaisePropertyChanged("AgeData");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Amount {
            get {
                return this.AmountField;
            }
            set {
                if ((this.AmountField.Equals(value) != true)) {
                    this.AmountField = value;
                    this.RaisePropertyChanged("Amount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ShoesWPF.ServiceReference.GenderDataService GenderData {
            get {
                return this.GenderDataField;
            }
            set {
                if ((object.ReferenceEquals(this.GenderDataField, value) != true)) {
                    this.GenderDataField = value;
                    this.RaisePropertyChanged("GenderData");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ImagePath {
            get {
                return this.ImagePathField;
            }
            set {
                if ((object.ReferenceEquals(this.ImagePathField, value) != true)) {
                    this.ImagePathField = value;
                    this.RaisePropertyChanged("ImagePath");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal IncomePrice {
            get {
                return this.IncomePriceField;
            }
            set {
                if ((this.IncomePriceField.Equals(value) != true)) {
                    this.IncomePriceField = value;
                    this.RaisePropertyChanged("IncomePrice");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ShoesWPF.ServiceReference.FactoryDataService Manufacturer {
            get {
                return this.ManufacturerField;
            }
            set {
                if ((object.ReferenceEquals(this.ManufacturerField, value) != true)) {
                    this.ManufacturerField = value;
                    this.RaisePropertyChanged("Manufacturer");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ModelName {
            get {
                return this.ModelNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ModelNameField, value) != true)) {
                    this.ModelNameField = value;
                    this.RaisePropertyChanged("ModelName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ShoesWPF.ServiceReference.SizeDataService ModelSize {
            get {
                return this.ModelSizeField;
            }
            set {
                if ((object.ReferenceEquals(this.ModelSizeField, value) != true)) {
                    this.ModelSizeField = value;
                    this.RaisePropertyChanged("ModelSize");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AgeStatusDataService", Namespace="http://schemas.datacontract.org/2004/07/ConsoleShoesServer.ShopDataService")]
    [System.SerializableAttribute()]
    public partial class AgeStatusDataService : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GenderDataService", Namespace="http://schemas.datacontract.org/2004/07/ConsoleShoesServer.ShopDataService")]
    [System.SerializableAttribute()]
    public partial class GenderDataService : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SizeDataService", Namespace="http://schemas.datacontract.org/2004/07/ConsoleShoesServer.ShopDataService")]
    [System.SerializableAttribute()]
    public partial class SizeDataService : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MeasureField;
        
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
        public int Measure {
            get {
                return this.MeasureField;
            }
            set {
                if ((this.MeasureField.Equals(value) != true)) {
                    this.MeasureField = value;
                    this.RaisePropertyChanged("Measure");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IFactoryContract")]
    public interface IFactoryContract {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFactoryContract/getFactories", ReplyAction="http://tempuri.org/IFactoryContract/getFactoriesResponse")]
        ShoesWPF.ServiceReference.FactoryDataService[] getFactories();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFactoryContract/getFactories", ReplyAction="http://tempuri.org/IFactoryContract/getFactoriesResponse")]
        System.Threading.Tasks.Task<ShoesWPF.ServiceReference.FactoryDataService[]> getFactoriesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFactoryContract/addFactory", ReplyAction="http://tempuri.org/IFactoryContract/addFactoryResponse")]
        void addFactory(ShoesWPF.ServiceReference.FactoryDataService tFactory);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFactoryContract/addFactory", ReplyAction="http://tempuri.org/IFactoryContract/addFactoryResponse")]
        System.Threading.Tasks.Task addFactoryAsync(ShoesWPF.ServiceReference.FactoryDataService tFactory);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IFactoryContractChannel : ShoesWPF.ServiceReference.IFactoryContract, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FactoryContractClient : System.ServiceModel.ClientBase<ShoesWPF.ServiceReference.IFactoryContract>, ShoesWPF.ServiceReference.IFactoryContract {
        
        public FactoryContractClient() {
        }
        
        public FactoryContractClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FactoryContractClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FactoryContractClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FactoryContractClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ShoesWPF.ServiceReference.FactoryDataService[] getFactories() {
            return base.Channel.getFactories();
        }
        
        public System.Threading.Tasks.Task<ShoesWPF.ServiceReference.FactoryDataService[]> getFactoriesAsync() {
            return base.Channel.getFactoriesAsync();
        }
        
        public void addFactory(ShoesWPF.ServiceReference.FactoryDataService tFactory) {
            base.Channel.addFactory(tFactory);
        }
        
        public System.Threading.Tasks.Task addFactoryAsync(ShoesWPF.ServiceReference.FactoryDataService tFactory) {
            return base.Channel.addFactoryAsync(tFactory);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IShoesContract")]
    public interface IShoesContract {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShoesContract/getAllShoes", ReplyAction="http://tempuri.org/IShoesContract/getAllShoesResponse")]
        ShoesWPF.ServiceReference.ShoesDataService[] getAllShoes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShoesContract/getAllShoes", ReplyAction="http://tempuri.org/IShoesContract/getAllShoesResponse")]
        System.Threading.Tasks.Task<ShoesWPF.ServiceReference.ShoesDataService[]> getAllShoesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShoesContract/addShoe", ReplyAction="http://tempuri.org/IShoesContract/addShoeResponse")]
        void addShoe(ShoesWPF.ServiceReference.ShoesDataService tShoe);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShoesContract/addShoe", ReplyAction="http://tempuri.org/IShoesContract/addShoeResponse")]
        System.Threading.Tasks.Task addShoeAsync(ShoesWPF.ServiceReference.ShoesDataService tShoe);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IShoesContractChannel : ShoesWPF.ServiceReference.IShoesContract, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ShoesContractClient : System.ServiceModel.ClientBase<ShoesWPF.ServiceReference.IShoesContract>, ShoesWPF.ServiceReference.IShoesContract {
        
        public ShoesContractClient() {
        }
        
        public ShoesContractClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ShoesContractClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ShoesContractClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ShoesContractClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ShoesWPF.ServiceReference.ShoesDataService[] getAllShoes() {
            return base.Channel.getAllShoes();
        }
        
        public System.Threading.Tasks.Task<ShoesWPF.ServiceReference.ShoesDataService[]> getAllShoesAsync() {
            return base.Channel.getAllShoesAsync();
        }
        
        public void addShoe(ShoesWPF.ServiceReference.ShoesDataService tShoe) {
            base.Channel.addShoe(tShoe);
        }
        
        public System.Threading.Tasks.Task addShoeAsync(ShoesWPF.ServiceReference.ShoesDataService tShoe) {
            return base.Channel.addShoeAsync(tShoe);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IShoesLoginContract")]
    public interface IShoesLoginContract {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShoesLoginContract/CheckLogin", ReplyAction="http://tempuri.org/IShoesLoginContract/CheckLoginResponse")]
        bool CheckLogin(string LogIn, string PassWord);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShoesLoginContract/CheckLogin", ReplyAction="http://tempuri.org/IShoesLoginContract/CheckLoginResponse")]
        System.Threading.Tasks.Task<bool> CheckLoginAsync(string LogIn, string PassWord);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IShoesLoginContractChannel : ShoesWPF.ServiceReference.IShoesLoginContract, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ShoesLoginContractClient : System.ServiceModel.ClientBase<ShoesWPF.ServiceReference.IShoesLoginContract>, ShoesWPF.ServiceReference.IShoesLoginContract {
        
        public ShoesLoginContractClient() {
        }
        
        public ShoesLoginContractClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ShoesLoginContractClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ShoesLoginContractClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ShoesLoginContractClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool CheckLogin(string LogIn, string PassWord) {
            return base.Channel.CheckLogin(LogIn, PassWord);
        }
        
        public System.Threading.Tasks.Task<bool> CheckLoginAsync(string LogIn, string PassWord) {
            return base.Channel.CheckLoginAsync(LogIn, PassWord);
        }
    }
}