﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShoesWPF.ServiceReferenceHome {
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
        private ShoesWPF.ServiceReferenceHome.AgeStatusDataService AgeDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AmountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ShoesWPF.ServiceReferenceHome.GenderDataService GenderDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ImagePathField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal IncomePriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ShoesWPF.ServiceReferenceHome.FactoryDataService ManufacturerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ModelNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ShoesWPF.ServiceReferenceHome.SizeDataService ModelSizeField;
        
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
        public ShoesWPF.ServiceReferenceHome.AgeStatusDataService AgeData {
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
        public ShoesWPF.ServiceReferenceHome.GenderDataService GenderData {
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
        public ShoesWPF.ServiceReferenceHome.FactoryDataService Manufacturer {
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
        public ShoesWPF.ServiceReferenceHome.SizeDataService ModelSize {
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceHome.IFactoryContract")]
    public interface IFactoryContract {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFactoryContract/getFactories", ReplyAction="http://tempuri.org/IFactoryContract/getFactoriesResponse")]
        ShoesWPF.ServiceReferenceHome.FactoryDataService[] getFactories();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFactoryContract/getFactories", ReplyAction="http://tempuri.org/IFactoryContract/getFactoriesResponse")]
        System.Threading.Tasks.Task<ShoesWPF.ServiceReferenceHome.FactoryDataService[]> getFactoriesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFactoryContract/addFactory", ReplyAction="http://tempuri.org/IFactoryContract/addFactoryResponse")]
        void addFactory(ShoesWPF.ServiceReferenceHome.FactoryDataService tFactory);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFactoryContract/addFactory", ReplyAction="http://tempuri.org/IFactoryContract/addFactoryResponse")]
        System.Threading.Tasks.Task addFactoryAsync(ShoesWPF.ServiceReferenceHome.FactoryDataService tFactory);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IFactoryContractChannel : ShoesWPF.ServiceReferenceHome.IFactoryContract, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FactoryContractClient : System.ServiceModel.ClientBase<ShoesWPF.ServiceReferenceHome.IFactoryContract>, ShoesWPF.ServiceReferenceHome.IFactoryContract {
        
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
        
        public ShoesWPF.ServiceReferenceHome.FactoryDataService[] getFactories() {
            return base.Channel.getFactories();
        }
        
        public System.Threading.Tasks.Task<ShoesWPF.ServiceReferenceHome.FactoryDataService[]> getFactoriesAsync() {
            return base.Channel.getFactoriesAsync();
        }
        
        public void addFactory(ShoesWPF.ServiceReferenceHome.FactoryDataService tFactory) {
            base.Channel.addFactory(tFactory);
        }
        
        public System.Threading.Tasks.Task addFactoryAsync(ShoesWPF.ServiceReferenceHome.FactoryDataService tFactory) {
            return base.Channel.addFactoryAsync(tFactory);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceHome.IShoesContract")]
    public interface IShoesContract {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShoesContract/getAllShoes", ReplyAction="http://tempuri.org/IShoesContract/getAllShoesResponse")]
        ShoesWPF.ServiceReferenceHome.ShoesDataService[] getAllShoes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShoesContract/getAllShoes", ReplyAction="http://tempuri.org/IShoesContract/getAllShoesResponse")]
        System.Threading.Tasks.Task<ShoesWPF.ServiceReferenceHome.ShoesDataService[]> getAllShoesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShoesContract/addShoe", ReplyAction="http://tempuri.org/IShoesContract/addShoeResponse")]
        void addShoe(ShoesWPF.ServiceReferenceHome.ShoesDataService tShoe);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShoesContract/addShoe", ReplyAction="http://tempuri.org/IShoesContract/addShoeResponse")]
        System.Threading.Tasks.Task addShoeAsync(ShoesWPF.ServiceReferenceHome.ShoesDataService tShoe);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IShoesContractChannel : ShoesWPF.ServiceReferenceHome.IShoesContract, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ShoesContractClient : System.ServiceModel.ClientBase<ShoesWPF.ServiceReferenceHome.IShoesContract>, ShoesWPF.ServiceReferenceHome.IShoesContract {
        
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
        
        public ShoesWPF.ServiceReferenceHome.ShoesDataService[] getAllShoes() {
            return base.Channel.getAllShoes();
        }
        
        public System.Threading.Tasks.Task<ShoesWPF.ServiceReferenceHome.ShoesDataService[]> getAllShoesAsync() {
            return base.Channel.getAllShoesAsync();
        }
        
        public void addShoe(ShoesWPF.ServiceReferenceHome.ShoesDataService tShoe) {
            base.Channel.addShoe(tShoe);
        }
        
        public System.Threading.Tasks.Task addShoeAsync(ShoesWPF.ServiceReferenceHome.ShoesDataService tShoe) {
            return base.Channel.addShoeAsync(tShoe);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceHome.IShoesLoginContract")]
    public interface IShoesLoginContract {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShoesLoginContract/CheckLogin", ReplyAction="http://tempuri.org/IShoesLoginContract/CheckLoginResponse")]
        bool CheckLogin(string LogIn, string PassWord);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShoesLoginContract/CheckLogin", ReplyAction="http://tempuri.org/IShoesLoginContract/CheckLoginResponse")]
        System.Threading.Tasks.Task<bool> CheckLoginAsync(string LogIn, string PassWord);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IShoesLoginContractChannel : ShoesWPF.ServiceReferenceHome.IShoesLoginContract, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ShoesLoginContractClient : System.ServiceModel.ClientBase<ShoesWPF.ServiceReferenceHome.IShoesLoginContract>, ShoesWPF.ServiceReferenceHome.IShoesLoginContract {
        
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceHome.IShoesGender")]
    public interface IShoesGender {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShoesGender/GetGender", ReplyAction="http://tempuri.org/IShoesGender/GetGenderResponse")]
        ShoesWPF.ServiceReferenceHome.GenderDataService[] GetGender();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShoesGender/GetGender", ReplyAction="http://tempuri.org/IShoesGender/GetGenderResponse")]
        System.Threading.Tasks.Task<ShoesWPF.ServiceReferenceHome.GenderDataService[]> GetGenderAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IShoesGenderChannel : ShoesWPF.ServiceReferenceHome.IShoesGender, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ShoesGenderClient : System.ServiceModel.ClientBase<ShoesWPF.ServiceReferenceHome.IShoesGender>, ShoesWPF.ServiceReferenceHome.IShoesGender {
        
        public ShoesGenderClient() {
        }
        
        public ShoesGenderClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ShoesGenderClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ShoesGenderClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ShoesGenderClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ShoesWPF.ServiceReferenceHome.GenderDataService[] GetGender() {
            return base.Channel.GetGender();
        }
        
        public System.Threading.Tasks.Task<ShoesWPF.ServiceReferenceHome.GenderDataService[]> GetGenderAsync() {
            return base.Channel.GetGenderAsync();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceHome.IShoesSize")]
    public interface IShoesSize {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShoesSize/GetSizes", ReplyAction="http://tempuri.org/IShoesSize/GetSizesResponse")]
        ShoesWPF.ServiceReferenceHome.SizeDataService[] GetSizes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShoesSize/GetSizes", ReplyAction="http://tempuri.org/IShoesSize/GetSizesResponse")]
        System.Threading.Tasks.Task<ShoesWPF.ServiceReferenceHome.SizeDataService[]> GetSizesAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IShoesSizeChannel : ShoesWPF.ServiceReferenceHome.IShoesSize, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ShoesSizeClient : System.ServiceModel.ClientBase<ShoesWPF.ServiceReferenceHome.IShoesSize>, ShoesWPF.ServiceReferenceHome.IShoesSize {
        
        public ShoesSizeClient() {
        }
        
        public ShoesSizeClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ShoesSizeClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ShoesSizeClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ShoesSizeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ShoesWPF.ServiceReferenceHome.SizeDataService[] GetSizes() {
            return base.Channel.GetSizes();
        }
        
        public System.Threading.Tasks.Task<ShoesWPF.ServiceReferenceHome.SizeDataService[]> GetSizesAsync() {
            return base.Channel.GetSizesAsync();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceHome.IAgeStatus")]
    public interface IAgeStatus {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAgeStatus/GetGetAgeStatus", ReplyAction="http://tempuri.org/IAgeStatus/GetGetAgeStatusResponse")]
        ShoesWPF.ServiceReferenceHome.AgeStatusDataService[] GetGetAgeStatus();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAgeStatus/GetGetAgeStatus", ReplyAction="http://tempuri.org/IAgeStatus/GetGetAgeStatusResponse")]
        System.Threading.Tasks.Task<ShoesWPF.ServiceReferenceHome.AgeStatusDataService[]> GetGetAgeStatusAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAgeStatusChannel : ShoesWPF.ServiceReferenceHome.IAgeStatus, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AgeStatusClient : System.ServiceModel.ClientBase<ShoesWPF.ServiceReferenceHome.IAgeStatus>, ShoesWPF.ServiceReferenceHome.IAgeStatus {
        
        public AgeStatusClient() {
        }
        
        public AgeStatusClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AgeStatusClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AgeStatusClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AgeStatusClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ShoesWPF.ServiceReferenceHome.AgeStatusDataService[] GetGetAgeStatus() {
            return base.Channel.GetGetAgeStatus();
        }
        
        public System.Threading.Tasks.Task<ShoesWPF.ServiceReferenceHome.AgeStatusDataService[]> GetGetAgeStatusAsync() {
            return base.Channel.GetGetAgeStatusAsync();
        }
    }
}
