﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestWindows_WCF_CheckSalud.ProxyPaciente {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PacienteDC", Namespace="http://schemas.datacontract.org/2004/07/WCF_CheckSalud")]
    [System.SerializableAttribute()]
    public partial class PacienteDC : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime Fec_RegField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime Fech_Ult_ModField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Id_UbigeoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Usu_RegistroField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Usu_Ult_ModField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string apePacienteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string codEmpresaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string codPacienteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string direcPacienteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string dniPacienteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string emailPacienteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short estadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime fechaIngresoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime fechaNacimientoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] fotoPacienteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nomPacienteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string numTelefonoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int sexoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short tipoClienteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string tipoSangreField;
        
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
        public System.DateTime Fec_Reg {
            get {
                return this.Fec_RegField;
            }
            set {
                if ((this.Fec_RegField.Equals(value) != true)) {
                    this.Fec_RegField = value;
                    this.RaisePropertyChanged("Fec_Reg");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Fech_Ult_Mod {
            get {
                return this.Fech_Ult_ModField;
            }
            set {
                if ((this.Fech_Ult_ModField.Equals(value) != true)) {
                    this.Fech_Ult_ModField = value;
                    this.RaisePropertyChanged("Fech_Ult_Mod");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Id_Ubigeo {
            get {
                return this.Id_UbigeoField;
            }
            set {
                if ((object.ReferenceEquals(this.Id_UbigeoField, value) != true)) {
                    this.Id_UbigeoField = value;
                    this.RaisePropertyChanged("Id_Ubigeo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Usu_Registro {
            get {
                return this.Usu_RegistroField;
            }
            set {
                if ((object.ReferenceEquals(this.Usu_RegistroField, value) != true)) {
                    this.Usu_RegistroField = value;
                    this.RaisePropertyChanged("Usu_Registro");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Usu_Ult_Mod {
            get {
                return this.Usu_Ult_ModField;
            }
            set {
                if ((object.ReferenceEquals(this.Usu_Ult_ModField, value) != true)) {
                    this.Usu_Ult_ModField = value;
                    this.RaisePropertyChanged("Usu_Ult_Mod");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string apePaciente {
            get {
                return this.apePacienteField;
            }
            set {
                if ((object.ReferenceEquals(this.apePacienteField, value) != true)) {
                    this.apePacienteField = value;
                    this.RaisePropertyChanged("apePaciente");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string codEmpresa {
            get {
                return this.codEmpresaField;
            }
            set {
                if ((object.ReferenceEquals(this.codEmpresaField, value) != true)) {
                    this.codEmpresaField = value;
                    this.RaisePropertyChanged("codEmpresa");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string codPaciente {
            get {
                return this.codPacienteField;
            }
            set {
                if ((object.ReferenceEquals(this.codPacienteField, value) != true)) {
                    this.codPacienteField = value;
                    this.RaisePropertyChanged("codPaciente");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string direcPaciente {
            get {
                return this.direcPacienteField;
            }
            set {
                if ((object.ReferenceEquals(this.direcPacienteField, value) != true)) {
                    this.direcPacienteField = value;
                    this.RaisePropertyChanged("direcPaciente");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string dniPaciente {
            get {
                return this.dniPacienteField;
            }
            set {
                if ((object.ReferenceEquals(this.dniPacienteField, value) != true)) {
                    this.dniPacienteField = value;
                    this.RaisePropertyChanged("dniPaciente");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string emailPaciente {
            get {
                return this.emailPacienteField;
            }
            set {
                if ((object.ReferenceEquals(this.emailPacienteField, value) != true)) {
                    this.emailPacienteField = value;
                    this.RaisePropertyChanged("emailPaciente");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short estado {
            get {
                return this.estadoField;
            }
            set {
                if ((this.estadoField.Equals(value) != true)) {
                    this.estadoField = value;
                    this.RaisePropertyChanged("estado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime fechaIngreso {
            get {
                return this.fechaIngresoField;
            }
            set {
                if ((this.fechaIngresoField.Equals(value) != true)) {
                    this.fechaIngresoField = value;
                    this.RaisePropertyChanged("fechaIngreso");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime fechaNacimiento {
            get {
                return this.fechaNacimientoField;
            }
            set {
                if ((this.fechaNacimientoField.Equals(value) != true)) {
                    this.fechaNacimientoField = value;
                    this.RaisePropertyChanged("fechaNacimiento");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] fotoPaciente {
            get {
                return this.fotoPacienteField;
            }
            set {
                if ((object.ReferenceEquals(this.fotoPacienteField, value) != true)) {
                    this.fotoPacienteField = value;
                    this.RaisePropertyChanged("fotoPaciente");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nomPaciente {
            get {
                return this.nomPacienteField;
            }
            set {
                if ((object.ReferenceEquals(this.nomPacienteField, value) != true)) {
                    this.nomPacienteField = value;
                    this.RaisePropertyChanged("nomPaciente");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string numTelefono {
            get {
                return this.numTelefonoField;
            }
            set {
                if ((object.ReferenceEquals(this.numTelefonoField, value) != true)) {
                    this.numTelefonoField = value;
                    this.RaisePropertyChanged("numTelefono");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int sexo {
            get {
                return this.sexoField;
            }
            set {
                if ((this.sexoField.Equals(value) != true)) {
                    this.sexoField = value;
                    this.RaisePropertyChanged("sexo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short tipoCliente {
            get {
                return this.tipoClienteField;
            }
            set {
                if ((this.tipoClienteField.Equals(value) != true)) {
                    this.tipoClienteField = value;
                    this.RaisePropertyChanged("tipoCliente");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string tipoSangre {
            get {
                return this.tipoSangreField;
            }
            set {
                if ((object.ReferenceEquals(this.tipoSangreField, value) != true)) {
                    this.tipoSangreField = value;
                    this.RaisePropertyChanged("tipoSangre");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProxyPaciente.IServicioPaciente")]
    public interface IServicioPaciente {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioPaciente/Consultar", ReplyAction="http://tempuri.org/IServicioPaciente/ConsultarResponse")]
        TestWindows_WCF_CheckSalud.ProxyPaciente.PacienteDC Consultar(string strCodigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioPaciente/Consultar", ReplyAction="http://tempuri.org/IServicioPaciente/ConsultarResponse")]
        System.Threading.Tasks.Task<TestWindows_WCF_CheckSalud.ProxyPaciente.PacienteDC> ConsultarAsync(string strCodigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioPaciente/Listar", ReplyAction="http://tempuri.org/IServicioPaciente/ListarResponse")]
        TestWindows_WCF_CheckSalud.ProxyPaciente.PacienteDC[] Listar();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioPaciente/Listar", ReplyAction="http://tempuri.org/IServicioPaciente/ListarResponse")]
        System.Threading.Tasks.Task<TestWindows_WCF_CheckSalud.ProxyPaciente.PacienteDC[]> ListarAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioPaciente/Insertar", ReplyAction="http://tempuri.org/IServicioPaciente/InsertarResponse")]
        bool Insertar(TestWindows_WCF_CheckSalud.ProxyPaciente.PacienteDC paciente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioPaciente/Insertar", ReplyAction="http://tempuri.org/IServicioPaciente/InsertarResponse")]
        System.Threading.Tasks.Task<bool> InsertarAsync(TestWindows_WCF_CheckSalud.ProxyPaciente.PacienteDC paciente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioPaciente/Actualizar", ReplyAction="http://tempuri.org/IServicioPaciente/ActualizarResponse")]
        bool Actualizar(TestWindows_WCF_CheckSalud.ProxyPaciente.PacienteDC paciente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioPaciente/Actualizar", ReplyAction="http://tempuri.org/IServicioPaciente/ActualizarResponse")]
        System.Threading.Tasks.Task<bool> ActualizarAsync(TestWindows_WCF_CheckSalud.ProxyPaciente.PacienteDC paciente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioPaciente/Eliminar", ReplyAction="http://tempuri.org/IServicioPaciente/EliminarResponse")]
        bool Eliminar(string strCodigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioPaciente/Eliminar", ReplyAction="http://tempuri.org/IServicioPaciente/EliminarResponse")]
        System.Threading.Tasks.Task<bool> EliminarAsync(string strCodigo);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicioPacienteChannel : TestWindows_WCF_CheckSalud.ProxyPaciente.IServicioPaciente, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioPacienteClient : System.ServiceModel.ClientBase<TestWindows_WCF_CheckSalud.ProxyPaciente.IServicioPaciente>, TestWindows_WCF_CheckSalud.ProxyPaciente.IServicioPaciente {
        
        public ServicioPacienteClient() {
        }
        
        public ServicioPacienteClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioPacienteClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioPacienteClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioPacienteClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public TestWindows_WCF_CheckSalud.ProxyPaciente.PacienteDC Consultar(string strCodigo) {
            return base.Channel.Consultar(strCodigo);
        }
        
        public System.Threading.Tasks.Task<TestWindows_WCF_CheckSalud.ProxyPaciente.PacienteDC> ConsultarAsync(string strCodigo) {
            return base.Channel.ConsultarAsync(strCodigo);
        }
        
        public TestWindows_WCF_CheckSalud.ProxyPaciente.PacienteDC[] Listar() {
            return base.Channel.Listar();
        }
        
        public System.Threading.Tasks.Task<TestWindows_WCF_CheckSalud.ProxyPaciente.PacienteDC[]> ListarAsync() {
            return base.Channel.ListarAsync();
        }
        
        public bool Insertar(TestWindows_WCF_CheckSalud.ProxyPaciente.PacienteDC paciente) {
            return base.Channel.Insertar(paciente);
        }
        
        public System.Threading.Tasks.Task<bool> InsertarAsync(TestWindows_WCF_CheckSalud.ProxyPaciente.PacienteDC paciente) {
            return base.Channel.InsertarAsync(paciente);
        }
        
        public bool Actualizar(TestWindows_WCF_CheckSalud.ProxyPaciente.PacienteDC paciente) {
            return base.Channel.Actualizar(paciente);
        }
        
        public System.Threading.Tasks.Task<bool> ActualizarAsync(TestWindows_WCF_CheckSalud.ProxyPaciente.PacienteDC paciente) {
            return base.Channel.ActualizarAsync(paciente);
        }
        
        public bool Eliminar(string strCodigo) {
            return base.Channel.Eliminar(strCodigo);
        }
        
        public System.Threading.Tasks.Task<bool> EliminarAsync(string strCodigo) {
            return base.Channel.EliminarAsync(strCodigo);
        }
    }
}
