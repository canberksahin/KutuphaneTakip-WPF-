//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_OkuyucuListesi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_OkuyucuListesi()
        {
            this.tbl_EmanetListesi = new HashSet<tbl_EmanetListesi>();
        }
    
        public int ID { get; set; }
        public Nullable<int> TC { get; set; }
        public string AdSoyad { get; set; }
        public string Adresi { get; set; }
        public string Email { get; set; }
        public Nullable<int> Telefon { get; set; }
        public byte[] Resim { get; set; }
        public Nullable<int> OkulNo { get; set; }
        public string Sinif { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_EmanetListesi> tbl_EmanetListesi { get; set; }
    }
}