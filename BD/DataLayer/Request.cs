//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.ObjectModel;
    
    public partial class Request
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Request()
        {
            this.Activities = new ObservableCollection<Activity>();
        }
    
        public System.Guid Id { get; set; }
        public System.Guid ObjectId { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string Result { get; set; }
        public Nullable<System.Guid> PersonelId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableCollection<Activity> Activities { get; set; }
        public virtual Object Object { get; set; }
        public virtual Personel Personel { get; set; }
    }
}
