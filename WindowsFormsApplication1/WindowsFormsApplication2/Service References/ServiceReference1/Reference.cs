﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClinicalAlert.ServiceReference1 {
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
        private System.DateTime dataOfRepositField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nomeUtenteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string sUtenteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int snsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int snsUtenteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string typeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string valueRField;
        
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
        public string nomeUtente {
            get {
                return this.nomeUtenteField;
            }
            set {
                if ((object.ReferenceEquals(this.nomeUtenteField, value) != true)) {
                    this.nomeUtenteField = value;
                    this.RaisePropertyChanged("nomeUtente");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string sUtente {
            get {
                return this.sUtenteField;
            }
            set {
                if ((object.ReferenceEquals(this.sUtenteField, value) != true)) {
                    this.sUtenteField = value;
                    this.RaisePropertyChanged("sUtente");
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
        public int snsUtente {
            get {
                return this.snsUtenteField;
            }
            set {
                if ((this.snsUtenteField.Equals(value) != true)) {
                    this.snsUtenteField = value;
                    this.RaisePropertyChanged("snsUtente");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string type {
            get {
                return this.typeField;
            }
            set {
                if ((object.ReferenceEquals(this.typeField, value) != true)) {
                    this.typeField = value;
                    this.RaisePropertyChanged("type");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string valueR {
            get {
                return this.valueRField;
            }
            set {
                if ((object.ReferenceEquals(this.valueRField, value) != true)) {
                    this.valueRField = value;
                    this.RaisePropertyChanged("valueR");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="EstatisticasWeb", Namespace="http://schemas.datacontract.org/2004/07/ClassLibraryMedAc")]
    [System.SerializableAttribute()]
    public partial class EstatisticasWeb : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string endDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime startDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string tipoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int valorMaxField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double valorMedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int valorMinField;
        
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
        public string endDate {
            get {
                return this.endDateField;
            }
            set {
                if ((object.ReferenceEquals(this.endDateField, value) != true)) {
                    this.endDateField = value;
                    this.RaisePropertyChanged("endDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime startDate {
            get {
                return this.startDateField;
            }
            set {
                if ((this.startDateField.Equals(value) != true)) {
                    this.startDateField = value;
                    this.RaisePropertyChanged("startDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string tipo {
            get {
                return this.tipoField;
            }
            set {
                if ((object.ReferenceEquals(this.tipoField, value) != true)) {
                    this.tipoField = value;
                    this.RaisePropertyChanged("tipo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int valorMax {
            get {
                return this.valorMaxField;
            }
            set {
                if ((this.valorMaxField.Equals(value) != true)) {
                    this.valorMaxField = value;
                    this.RaisePropertyChanged("valorMax");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double valorMed {
            get {
                return this.valorMedField;
            }
            set {
                if ((this.valorMedField.Equals(value) != true)) {
                    this.valorMedField = value;
                    this.RaisePropertyChanged("valorMed");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int valorMin {
            get {
                return this.valorMinField;
            }
            set {
                if ((this.valorMinField.Equals(value) != true)) {
                    this.valorMinField = value;
                    this.RaisePropertyChanged("valorMin");
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
        ClinicalAlert.ServiceReference1.UtenteWeb GetUtenteBySNS(int sns);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetUtenteBySNS", ReplyAction="http://tempuri.org/IService1/GetUtenteBySNSResponse")]
        System.Threading.Tasks.Task<ClinicalAlert.ServiceReference1.UtenteWeb> GetUtenteBySNSAsync(int sns);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddUtente", ReplyAction="http://tempuri.org/IService1/AddUtenteResponse")]
        void AddUtente(ClinicalAlert.ServiceReference1.UtenteWeb utente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddUtente", ReplyAction="http://tempuri.org/IService1/AddUtenteResponse")]
        System.Threading.Tasks.Task AddUtenteAsync(ClinicalAlert.ServiceReference1.UtenteWeb utente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EditUtente", ReplyAction="http://tempuri.org/IService1/EditUtenteResponse")]
        bool EditUtente(ClinicalAlert.ServiceReference1.UtenteWeb utente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EditUtente", ReplyAction="http://tempuri.org/IService1/EditUtenteResponse")]
        System.Threading.Tasks.Task<bool> EditUtenteAsync(ClinicalAlert.ServiceReference1.UtenteWeb utente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetListaUtentes", ReplyAction="http://tempuri.org/IService1/GetListaUtentesResponse")]
        ClinicalAlert.ServiceReference1.UtenteWeb[] GetListaUtentes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetListaUtentes", ReplyAction="http://tempuri.org/IService1/GetListaUtentesResponse")]
        System.Threading.Tasks.Task<ClinicalAlert.ServiceReference1.UtenteWeb[]> GetListaUtentesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetValuesbySNS", ReplyAction="http://tempuri.org/IService1/GetValuesbySNSResponse")]
        ClinicalAlert.ServiceReference1.ValoresWeb[] GetValuesbySNS(int sns, System.DateTime dataMax, System.DateTime dataMin);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetValuesbySNS", ReplyAction="http://tempuri.org/IService1/GetValuesbySNSResponse")]
        System.Threading.Tasks.Task<ClinicalAlert.ServiceReference1.ValoresWeb[]> GetValuesbySNSAsync(int sns, System.DateTime dataMax, System.DateTime dataMin);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddValues", ReplyAction="http://tempuri.org/IService1/AddValuesResponse")]
        void AddValues(int sns, string type, string value, System.DateTime data);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddValues", ReplyAction="http://tempuri.org/IService1/AddValuesResponse")]
        System.Threading.Tasks.Task AddValuesAsync(int sns, string type, string value, System.DateTime data);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetReportsHRbySNS", ReplyAction="http://tempuri.org/IService1/GetReportsHRbySNSResponse")]
        ClinicalAlert.ServiceReference1.EstatisticasWeb[] GetReportsHRbySNS(int sns, System.DateTime startDate, System.DateTime endDate, string type);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetReportsHRbySNS", ReplyAction="http://tempuri.org/IService1/GetReportsHRbySNSResponse")]
        System.Threading.Tasks.Task<ClinicalAlert.ServiceReference1.EstatisticasWeb[]> GetReportsHRbySNSAsync(int sns, System.DateTime startDate, System.DateTime endDate, string type);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetRegistofGrahp", ReplyAction="http://tempuri.org/IService1/GetRegistofGrahpResponse")]
        ClinicalAlert.ServiceReference1.ValoresWeb[] GetRegistofGrahp(int sns, System.DateTime dataMax, System.DateTime dataMin);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetRegistofGrahp", ReplyAction="http://tempuri.org/IService1/GetRegistofGrahpResponse")]
        System.Threading.Tasks.Task<ClinicalAlert.ServiceReference1.ValoresWeb[]> GetRegistofGrahpAsync(int sns, System.DateTime dataMax, System.DateTime dataMin);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : ClinicalAlert.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<ClinicalAlert.ServiceReference1.IService1>, ClinicalAlert.ServiceReference1.IService1 {
        
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
        
        public ClinicalAlert.ServiceReference1.UtenteWeb GetUtenteBySNS(int sns) {
            return base.Channel.GetUtenteBySNS(sns);
        }
        
        public System.Threading.Tasks.Task<ClinicalAlert.ServiceReference1.UtenteWeb> GetUtenteBySNSAsync(int sns) {
            return base.Channel.GetUtenteBySNSAsync(sns);
        }
        
        public void AddUtente(ClinicalAlert.ServiceReference1.UtenteWeb utente) {
            base.Channel.AddUtente(utente);
        }
        
        public System.Threading.Tasks.Task AddUtenteAsync(ClinicalAlert.ServiceReference1.UtenteWeb utente) {
            return base.Channel.AddUtenteAsync(utente);
        }
        
        public bool EditUtente(ClinicalAlert.ServiceReference1.UtenteWeb utente) {
            return base.Channel.EditUtente(utente);
        }
        
        public System.Threading.Tasks.Task<bool> EditUtenteAsync(ClinicalAlert.ServiceReference1.UtenteWeb utente) {
            return base.Channel.EditUtenteAsync(utente);
        }
        
        public ClinicalAlert.ServiceReference1.UtenteWeb[] GetListaUtentes() {
            return base.Channel.GetListaUtentes();
        }
        
        public System.Threading.Tasks.Task<ClinicalAlert.ServiceReference1.UtenteWeb[]> GetListaUtentesAsync() {
            return base.Channel.GetListaUtentesAsync();
        }
        
        public ClinicalAlert.ServiceReference1.ValoresWeb[] GetValuesbySNS(int sns, System.DateTime dataMax, System.DateTime dataMin) {
            return base.Channel.GetValuesbySNS(sns, dataMax, dataMin);
        }
        
        public System.Threading.Tasks.Task<ClinicalAlert.ServiceReference1.ValoresWeb[]> GetValuesbySNSAsync(int sns, System.DateTime dataMax, System.DateTime dataMin) {
            return base.Channel.GetValuesbySNSAsync(sns, dataMax, dataMin);
        }
        
        public void AddValues(int sns, string type, string value, System.DateTime data) {
            base.Channel.AddValues(sns, type, value, data);
        }
        
        public System.Threading.Tasks.Task AddValuesAsync(int sns, string type, string value, System.DateTime data) {
            return base.Channel.AddValuesAsync(sns, type, value, data);
        }
        
        public ClinicalAlert.ServiceReference1.EstatisticasWeb[] GetReportsHRbySNS(int sns, System.DateTime startDate, System.DateTime endDate, string type) {
            return base.Channel.GetReportsHRbySNS(sns, startDate, endDate, type);
        }
        
        public System.Threading.Tasks.Task<ClinicalAlert.ServiceReference1.EstatisticasWeb[]> GetReportsHRbySNSAsync(int sns, System.DateTime startDate, System.DateTime endDate, string type) {
            return base.Channel.GetReportsHRbySNSAsync(sns, startDate, endDate, type);
        }
        
        public ClinicalAlert.ServiceReference1.ValoresWeb[] GetRegistofGrahp(int sns, System.DateTime dataMax, System.DateTime dataMin) {
            return base.Channel.GetRegistofGrahp(sns, dataMax, dataMin);
        }
        
        public System.Threading.Tasks.Task<ClinicalAlert.ServiceReference1.ValoresWeb[]> GetRegistofGrahpAsync(int sns, System.DateTime dataMax, System.DateTime dataMin) {
            return base.Channel.GetRegistofGrahpAsync(sns, dataMax, dataMin);
        }
    }
}
