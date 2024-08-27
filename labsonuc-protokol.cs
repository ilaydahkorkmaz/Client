public class Tlabsonucprotokol
{
     İstek tarihi
   public string Istektarihi { get; set; } // Gerekli (E)

    // Rapor tarihi
   public string Raportarihi { get; set; } // Gerekli (E)
   
    public string Raporadi { get; set; } // Gerekli (E)

 
    public string Istekno { get; set; } // Gerekli (E)
     TLabsonucdetay tablosu (Sonuçlar)
  public List<TLabsonucdetay> Sonuclar { get; set; } // Gerekli (E)

//    // Sonuç durumu
//    public string Sonucdurumu { get; set; } // Gerekli (E)

//    // Grup testi mi?
//    public string GrupTesti { get; set; } // Gerekli (E)

//    // Hata kodu
//    public string HataKodu { get; set; } // Gerekli (E)

//    // Hata açıklaması
//    public string HataAciklama { get; set; } // Gerekli (E)

//    // Rapor text (Radyoloji)
//    public string Raportext { get; set; } // Gerekli (E)
//}

