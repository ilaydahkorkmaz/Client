public class HomeController : Controller
   {
       public Tlabsonucprotokol GetTlabsonucprotokol()
        {
            // Tlabsonucprotokol nesnesi oluşturuldu
            Tlabsonucprotokol labSonucProtokol = new Tlabsonucprotokol();

            // Örnek veri atanması
            labSonucProtokol.Istektarihi = "24.08.2024";  
            labSonucProtokol.Raportarihi = "25.08.2024"; 
            labSonucProtokol.Raporadi = "Rapor 123";  
            labSonucProtokol.Istekno = "456789";  
            labSonucProtokol.Sonucdurumu = "Tamamlandı";  
            labSonucProtokol.Grup_testi = "Grup Testi A";  
            labSonucProtokol.Hata_kodu = "0";  
            labSonucProtokol.Hata_aciklama = "Başarılı";  
            labSonucProtokol.Raportext = "Radyolojik inceleme raporu"; 

            
            labSonucProtokol.Sonuclar = new TLabsonucdetay[]
            {
                new TLabsonucdetay
                {
                    TestAdi = "Test A",  
                    TestSonucu = "Negatif"  
                },
                new TLabsonucdetay
                {
                    TestAdi = "Test B",  
                    TestSonucu = "Pozitif"  
                }
            };
            return labSonucProtokol;
        }
    }
}
