﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfAppClient.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Movie", Namespace="http://schemas.datacontract.org/2004/07/MVVM_EF_WCF")]
    [System.SerializableAttribute()]
    public partial class Movie : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] PictureField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double RatingField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WpfAppClient.ServiceReference1.User UserField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UserIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int YearField;
        
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] Picture {
            get {
                return this.PictureField;
            }
            set {
                if ((object.ReferenceEquals(this.PictureField, value) != true)) {
                    this.PictureField = value;
                    this.RaisePropertyChanged("Picture");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Rating {
            get {
                return this.RatingField;
            }
            set {
                if ((this.RatingField.Equals(value) != true)) {
                    this.RatingField = value;
                    this.RaisePropertyChanged("Rating");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WpfAppClient.ServiceReference1.User User {
            get {
                return this.UserField;
            }
            set {
                if ((object.ReferenceEquals(this.UserField, value) != true)) {
                    this.UserField = value;
                    this.RaisePropertyChanged("User");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UserId {
            get {
                return this.UserIdField;
            }
            set {
                if ((this.UserIdField.Equals(value) != true)) {
                    this.UserIdField = value;
                    this.RaisePropertyChanged("UserId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Year {
            get {
                return this.YearField;
            }
            set {
                if ((this.YearField.Equals(value) != true)) {
                    this.YearField = value;
                    this.RaisePropertyChanged("Year");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/MVVM_EF_WCF")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<WpfAppClient.ServiceReference1.Movie> MoviesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WpfAppClient.ServiceReference1.Role RoleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int RoleIdField;
        
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
        public System.Collections.Generic.List<WpfAppClient.ServiceReference1.Movie> Movies {
            get {
                return this.MoviesField;
            }
            set {
                if ((object.ReferenceEquals(this.MoviesField, value) != true)) {
                    this.MoviesField = value;
                    this.RaisePropertyChanged("Movies");
                }
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WpfAppClient.ServiceReference1.Role Role {
            get {
                return this.RoleField;
            }
            set {
                if ((object.ReferenceEquals(this.RoleField, value) != true)) {
                    this.RoleField = value;
                    this.RaisePropertyChanged("Role");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int RoleId {
            get {
                return this.RoleIdField;
            }
            set {
                if ((this.RoleIdField.Equals(value) != true)) {
                    this.RoleIdField = value;
                    this.RaisePropertyChanged("RoleId");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Role", Namespace="http://schemas.datacontract.org/2004/07/MVVM_EF_WCF")]
    [System.SerializableAttribute()]
    public partial class Role : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IServiceAdmin")]
    public interface IServiceAdmin {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceUser/GetMovies", ReplyAction="http://tempuri.org/IServiceUser/GetMoviesResponse")]
        System.Collections.Generic.List<WpfAppClient.ServiceReference1.Movie> GetMovies();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceUser/GetMovies", ReplyAction="http://tempuri.org/IServiceUser/GetMoviesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<WpfAppClient.ServiceReference1.Movie>> GetMoviesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceUser/GetUser", ReplyAction="http://tempuri.org/IServiceUser/GetUserResponse")]
        WpfAppClient.ServiceReference1.User GetUser(string login, byte[] hash);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceUser/GetUser", ReplyAction="http://tempuri.org/IServiceUser/GetUserResponse")]
        System.Threading.Tasks.Task<WpfAppClient.ServiceReference1.User> GetUserAsync(string login, byte[] hash);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAdmin/AddMovie", ReplyAction="http://tempuri.org/IServiceAdmin/AddMovieResponse")]
        void AddMovie(WpfAppClient.ServiceReference1.Movie movie, WpfAppClient.ServiceReference1.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAdmin/AddMovie", ReplyAction="http://tempuri.org/IServiceAdmin/AddMovieResponse")]
        System.Threading.Tasks.Task AddMovieAsync(WpfAppClient.ServiceReference1.Movie movie, WpfAppClient.ServiceReference1.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAdmin/EditMovie", ReplyAction="http://tempuri.org/IServiceAdmin/EditMovieResponse")]
        void EditMovie(WpfAppClient.ServiceReference1.Movie movie);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAdmin/EditMovie", ReplyAction="http://tempuri.org/IServiceAdmin/EditMovieResponse")]
        System.Threading.Tasks.Task EditMovieAsync(WpfAppClient.ServiceReference1.Movie movie);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAdmin/RemoveMovie", ReplyAction="http://tempuri.org/IServiceAdmin/RemoveMovieResponse")]
        void RemoveMovie(WpfAppClient.ServiceReference1.Movie movie);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAdmin/RemoveMovie", ReplyAction="http://tempuri.org/IServiceAdmin/RemoveMovieResponse")]
        System.Threading.Tasks.Task RemoveMovieAsync(WpfAppClient.ServiceReference1.Movie movie);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceAdminChannel : WpfAppClient.ServiceReference1.IServiceAdmin, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceAdminClient : System.ServiceModel.ClientBase<WpfAppClient.ServiceReference1.IServiceAdmin>, WpfAppClient.ServiceReference1.IServiceAdmin {
        
        public ServiceAdminClient() {
        }
        
        public ServiceAdminClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceAdminClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceAdminClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceAdminClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<WpfAppClient.ServiceReference1.Movie> GetMovies() {
            return base.Channel.GetMovies();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<WpfAppClient.ServiceReference1.Movie>> GetMoviesAsync() {
            return base.Channel.GetMoviesAsync();
        }
        
        public WpfAppClient.ServiceReference1.User GetUser(string login, byte[] hash) {
            return base.Channel.GetUser(login, hash);
        }
        
        public System.Threading.Tasks.Task<WpfAppClient.ServiceReference1.User> GetUserAsync(string login, byte[] hash) {
            return base.Channel.GetUserAsync(login, hash);
        }
        
        public void AddMovie(WpfAppClient.ServiceReference1.Movie movie, WpfAppClient.ServiceReference1.User user) {
            base.Channel.AddMovie(movie, user);
        }
        
        public System.Threading.Tasks.Task AddMovieAsync(WpfAppClient.ServiceReference1.Movie movie, WpfAppClient.ServiceReference1.User user) {
            return base.Channel.AddMovieAsync(movie, user);
        }
        
        public void EditMovie(WpfAppClient.ServiceReference1.Movie movie) {
            base.Channel.EditMovie(movie);
        }
        
        public System.Threading.Tasks.Task EditMovieAsync(WpfAppClient.ServiceReference1.Movie movie) {
            return base.Channel.EditMovieAsync(movie);
        }
        
        public void RemoveMovie(WpfAppClient.ServiceReference1.Movie movie) {
            base.Channel.RemoveMovie(movie);
        }
        
        public System.Threading.Tasks.Task RemoveMovieAsync(WpfAppClient.ServiceReference1.Movie movie) {
            return base.Channel.RemoveMovieAsync(movie);
        }
    }
}
