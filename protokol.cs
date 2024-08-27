namespace MedEntegre.Controllers
{
    public class Tlabsonucprotokol
    {
        public string Istektarihi { get; set; } 
        public string Raportarihi { get; set; }  
        public string Raporadi { get; set; }  
        public string Istekno { get; set; }  
        public TLabsonucdetay[] Sonuclar { get; set; }  
        public string Sonucdurumu { get; set; }  
        public string Grup_testi { get; set; }  
        public string Hata_kodu { get; set; }  
        public string Hata_aciklama { get; set; }  
        public string Raportext { get; set; }  /
    }

    public class TLabsonucdetay
    {
        
        public string TestAdi { get; set; }  
        public string TestSonucu { get; set; }  
    }
