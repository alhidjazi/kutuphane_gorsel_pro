//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace de.pro
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_EmanetKitaplar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_EmanetKitaplar()
        {
            this.Tbl_Kayitlar = new HashSet<Tbl_Kayitlar>();
        }
    
        public short EmanetID { get; set; }
        public string EmanetTC { get; set; }
        public string EmanetAdSoyad { get; set; }
        public string EmanetYas { get; set; }
        public string EmanetTelefon { get; set; }
        public string EmanetKBarkod { get; set; }
        public string EmanetKAd { get; set; }
        public string EmanetKYazar { get; set; }
        public Nullable<int> EmanetKSayi { get; set; }
        public string EmanetKTeslim { get; set; }
        public string İade { get; set; }
        public string EmanetTeslimEdilenPer { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Kayitlar> Tbl_Kayitlar { get; set; }
    }
}
