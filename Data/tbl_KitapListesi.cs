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
    
    public partial class tbl_KitapListesi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_KitapListesi()
        {
            this.tbl_EmanetListesi = new HashSet<tbl_EmanetListesi>();
        }
    
        public string Barkod { get; set; }
        public Nullable<int> YazarAdiID { get; set; }
        public string KitapTuru { get; set; }
        public Nullable<int> YayinEviID { get; set; }
        public string KitapKonusu { get; set; }
        public string BaskiYeri { get; set; }
        public Nullable<int> BaskiSayisi { get; set; }
        public string BaskiTarihi { get; set; }
        public string TeminTuru { get; set; }
        public string TeminTarihi { get; set; }
        public Nullable<int> SayfaSayisi { get; set; }
        public byte[] Resim { get; set; }
        public int ID { get; set; }
        public string KitapAdi { get; set; }
        public Nullable<bool> EmanetDurumu { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_EmanetListesi> tbl_EmanetListesi { get; set; }
        public virtual tbl_YayinEvleri tbl_YayinEvleri { get; set; }
        public virtual tbl_Yazarlar tbl_Yazarlar { get; set; }
    }
}
