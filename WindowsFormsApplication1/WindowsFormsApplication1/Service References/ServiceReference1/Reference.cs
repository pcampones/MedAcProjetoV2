﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BOT.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UtenteWeb", Namespace="http://schemas.datacontract.org/2004/07/ServiceLayer")]
    [System.SerializableAttribute()]
    public partial class UtenteWeb : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string addressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string alergiesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ativeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int biField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime birthdateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string genderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int heightField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string mailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int nexOfKinContactField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int phoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int snsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string surnameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int weightField;
        
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
        public string address {
            get {
                return this.addressField;
            }
            set {
                if ((object.ReferenceEquals(this.addressField, value) != true)) {
                    this.addressField = value;
                    this.RaisePropertyChanged("address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int age {
            get {
                return this.ageField;
            }
            set {
                if ((this.ageField.Equals(value) != true)) {
                    this.ageField = value;
                    this.RaisePropertyChanged("age");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string alergies {
            get {
                return this.alergiesField;
            }
            set {
                if ((object.ReferenceEquals(this.alergiesField, value) != true)) {
                    this.alergiesField = value;
                    this.RaisePropertyChanged("alergies");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ative {
            get {
                return this.ativeField;
            }
            set {
                if ((object.ReferenceEquals(this.ativeField, value) != true)) {
                    this.ativeField = value;
                    this.RaisePropertyChanged("ative");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int bi {
            get {
                return this.biField;
            }
            set {
                if ((this.biField.Equals(value) != true)) {
                    this.biField = value;
                    this.RaisePropertyChanged("bi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime birthdate {
            get {
                return this.birthdateField;
            }
            set {
                if ((this.birthdateField.Equals(value) != true)) {
                    this.birthdateField = value;
                    this.RaisePropertyChanged("birthdate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string gender {
            get {
                return this.genderField;
            }
            set {
                if ((object.ReferenceEquals(this.genderField, value) != true)) {
                    this.genderField = value;
                    this.RaisePropertyChanged("gender");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int height {
            get {
                return this.heightField;
            }
            set {
                if ((this.heightField.Equals(value) != true)) {
                    this.heightField = value;
                    this.RaisePropertyChanged("height");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string mail {
            get {
                return this.mailField;
            }
            set {
                if ((object.ReferenceEquals(this.mailField, value) != true)) {
                    this.mailField = value;
                    this.RaisePropertyChanged("mail");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int nexOfKinContact {
            get {
                return this.nexOfKinContactField;
            }
            set {
                if ((this.nexOfKinContactField.Equals(value) != true)) {
                    this.nexOfKinContactField = value;
                    this.RaisePropertyChanged("nexOfKinContact");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int phone {
            get {
                return this.phoneField;
            }
            set {
                if ((this.phoneField.Equals(value) != true)) {
                    this.phoneField = value;
                    this.RaisePropertyChanged("phone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int sns {
            get {
                return this.snsField;
            }
            set {
                if ((this.snsField.Equals(value) != true)) {
                    this.snsField = value;
                    this.RaisePropertyChanged("sns");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string surname {
            get {
                return this.surnameField;
            }
            set {
                if ((object.ReferenceEquals(this.surnameField, value) != true)) {
                    this.surnameField = value;
                    this.RaisePropertyChanged("surname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int weight {
            get {
                return this.weightField;
            }
            set {
                if ((this.weightField.Equals(value) != true)) {
                    this.weightField = value;
                    this.RaisePropertyChanged("weight");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ValoresWeb", Namespace="http://schemas.datacontract.org/2004/07/ServiceLayer")]
    [System.SerializableAttribute()]
    public partial class ValoresWeb : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int bloodPressureMaxField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int bloodPressureMinField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime dataOfRepositField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int heartRateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int oxigenSatField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int snsField;
        
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
        public int bloodPressureMax {
            get {
                return this.bloodPressureMaxField;
            }
            set {
                if ((this.bloodPressureMaxField.Equals(value) != true)) {
                    this.bloodPressureMaxField = value;
                    this.RaisePropertyChanged("bloodPressureMax");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int bloodPressureMin {
            get {
                return this.bloodPressureMinField;
            }
            set {
                if ((this.bloodPressureMinField.Equals(value) != true)) {
                    this.bloodPressureMinField = value;
                    this.RaisePropertyChanged("bloodPressureMin");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime dataOfReposit {
            get {
                return this.dataOfRepositField;
            }
            set {
                if ((this.dataOfRepositField.Equals(value) != true)) {
                    this.dataOfRepositField = value;
                    this.RaisePropertyChanged("dataOfReposit");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int heartRate {
            get {
                return this.heartRateField;
            }
            set {
                if ((this.heartRateField.Equals(value) != true)) {
                    this.heartRateField = value;
                    this.RaisePropertyChanged("heartRate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int oxigenSat {
            get {
                return this.oxigenSatField;
            }
            set {
                if ((this.oxigenSatField.Equals(value) != true)) {
                    this.oxigenSatField = value;
                    this.RaisePropertyChanged("oxigenSat");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int sns {
            get {
                return this.snsField;
            }
            set {
                if ((this.snsField.Equals(value) != true)) {
                    this.snsField = value;
                    this.RaisePropertyChanged("sns");
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
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetUtenteBySNS", ReplyAction="http://tempuri.org/IService1/GetUtenteBySNSResponse")]
        BOT.ServiceReference1.UtenteWeb GetUtenteBySNS(int sns);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetUtenteBySNS", ReplyAction="http://tempuri.org/IService1/GetUtenteBySNSResponse")]
        System.Threading.Tasks.Task<BOT.ServiceReference1.UtenteWeb> GetUtenteBySNSAsync(int sns);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddUtente", ReplyAction="http://tempuri.org/IService1/AddUtenteResponse")]
        void AddUtente(BOT.ServiceReference1.UtenteWeb utente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddUtente", ReplyAction="http://tempuri.org/IService1/AddUtenteResponse")]
        System.Threading.Tasks.Task AddUtenteAsync(BOT.ServiceReference1.UtenteWeb utente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EditUtente", ReplyAction="http://tempuri.org/IService1/EditUtenteResponse")]
        bool EditUtente(BOT.ServiceReference1.UtenteWeb utente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EditUtente", ReplyAction="http://tempuri.org/IService1/EditUtenteResponse")]
        System.Threading.Tasks.Task<bool> EditUtenteAsync(BOT.ServiceReference1.UtenteWeb utente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetListaUtentes", ReplyAction="http://tempuri.org/IService1/GetListaUtentesResponse")]
        BOT.ServiceReference1.UtenteWeb[] GetListaUtentes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetListaUtentes", ReplyAction="http://tempuri.org/IService1/GetListaUtentesResponse")]
        System.Threading.Tasks.Task<BOT.ServiceReference1.UtenteWeb[]> GetListaUtentesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetValuesbySNS", ReplyAction="http://tempuri.org/IService1/GetValuesbySNSResponse")]
        BOT.ServiceReference1.ValoresWeb[] GetValuesbySNS(int sns);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetValuesbySNS", ReplyAction="http://tempuri.org/IService1/GetValuesbySNSResponse")]
        System.Threading.Tasks.Task<BOT.ServiceReference1.ValoresWeb[]> GetValuesbySNSAsync(int sns);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddValues", ReplyAction="http://tempuri.org/IService1/AddValuesResponse")]
        void AddValues(int sns, int bloodPressureMin, int bloodPressureMax, int heartRate, int oxygenSatu, System.DateTime data, int tempoTotal);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddValues", ReplyAction="http://tempuri.org/IService1/AddValuesResponse")]
        System.Threading.Tasks.Task AddValuesAsync(int sns, int bloodPressureMin, int bloodPressureMax, int heartRate, int oxygenSatu, System.DateTime data, int tempoTotal);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : BOT.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<BOT.ServiceReference1.IService1>, BOT.ServiceReference1.IService1 {
        
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
        
        public BOT.ServiceReference1.UtenteWeb GetUtenteBySNS(int sns) {
            return base.Channel.GetUtenteBySNS(sns);
        }
        
        public System.Threading.Tasks.Task<BOT.ServiceReference1.UtenteWeb> GetUtenteBySNSAsync(int sns) {
            return base.Channel.GetUtenteBySNSAsync(sns);
        }
        
        public void AddUtente(BOT.ServiceReference1.UtenteWeb utente) {
            base.Channel.AddUtente(utente);
        }
        
        public System.Threading.Tasks.Task AddUtenteAsync(BOT.ServiceReference1.UtenteWeb utente) {
            return base.Channel.AddUtenteAsync(utente);
        }
        
        public bool EditUtente(BOT.ServiceReference1.UtenteWeb utente) {
            return base.Channel.EditUtente(utente);
        }
        
        public System.Threading.Tasks.Task<bool> EditUtenteAsync(BOT.ServiceReference1.UtenteWeb utente) {
            return base.Channel.EditUtenteAsync(utente);
        }
        
        public BOT.ServiceReference1.UtenteWeb[] GetListaUtentes() {
            return base.Channel.GetListaUtentes();
        }
        
        public System.Threading.Tasks.Task<BOT.ServiceReference1.UtenteWeb[]> GetListaUtentesAsync() {
            return base.Channel.GetListaUtentesAsync();
        }
        
        public BOT.ServiceReference1.ValoresWeb[] GetValuesbySNS(int sns) {
            return base.Channel.GetValuesbySNS(sns);
        }
        
        public System.Threading.Tasks.Task<BOT.ServiceReference1.ValoresWeb[]> GetValuesbySNSAsync(int sns) {
            return base.Channel.GetValuesbySNSAsync(sns);
        }
        
        public void AddValues(int sns, int bloodPressureMin, int bloodPressureMax, int heartRate, int oxygenSatu, System.DateTime data, int tempoTotal) {
            base.Channel.AddValues(sns, bloodPressureMin, bloodPressureMax, heartRate, oxygenSatu, data, tempoTotal);
        }
        
        public System.Threading.Tasks.Task AddValuesAsync(int sns, int bloodPressureMin, int bloodPressureMax, int heartRate, int oxygenSatu, System.DateTime data, int tempoTotal) {
            return base.Channel.AddValuesAsync(sns, bloodPressureMin, bloodPressureMax, heartRate, oxygenSatu, data, tempoTotal);
        }
    }
}
