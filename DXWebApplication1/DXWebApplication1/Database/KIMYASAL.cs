//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DXWebApplication1.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class KIMYASAL
    {
        public int KIMYASAL_ID { get; set; }
        public Nullable<int> FK_KIMYASAL_TIPI { get; set; }
        public string LISTE_NO { get; set; }
        public string INGILIZCE_ADI { get; set; }
        public string TURKCE_ADI { get; set; }
        public string MADDE_NOTLARI { get; set; }
        public string EC_NO { get; set; }
        public string CAS_NO { get; set; }
        public Nullable<int> FK_ADLANDIRILMIS_MADDE_KATEGORI { get; set; }
        public string KONSANTRASYON_SINIRLARI { get; set; }
        public string TCDD_TUR { get; set; }
        public Nullable<double> TCDD_ESIK_DEGER { get; set; }
        public string MUSTAHZAR_NOTLARI { get; set; }
        public string KARISIM_BILGILERI { get; set; }
        public string UNADR_SINIF { get; set; }
    
        public virtual BILDIRIM_KIMYASALLARI BILDIRIM_KIMYASALLARI { get; set; }
    }
}