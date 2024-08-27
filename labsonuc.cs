namespace MedEntegre.Controllers
{
    public class TLabsonuc
   {
       public string Adisoyadi { get; set; }  // String, Adı Soyadı
       public string Yasi { get; set; }  // String, Yaşı
       public string Cinsiyet { get; set; }  // String, Cinsiyet
      public string Bolum { get; set; }  // String, Bölümü
       public string Hatakodu { get; set; }  // String, Hata kodu
       public string Hataaciklama { get; set; }  // String, Hata açıklaması
       public Tlabsonucprotokol[] Labsonuc { get; set; }  // Array_of_Tlabsonucprotokol, Tlabsonucprotokol
    }

   public class Tlabsonucprotokol
   {
       // Örnek alanlar, bunları ihtiyacınıza göre özelleştirin
        public int ProtokolNo { get; set; }  // Numeric, Protokol numarası
       public string Sonuc { get; set; }  // String, Sonuç açıklaması       // Diğer alanlar burada tanımlanabilir
   }

    public class HomeController : Controller
    {
        public TLabsonuc GetLabSonuc()
       {
           // TLabsonuc nesnesi oluşturuldu
           TLabsonuc labSonuc = new TLabsonuc();

            // Örnek veri atanması
           labSonuc.Adisoyadi = "Ahmet Yılmaz";  // String, Adı Soyadı
           labSonuc.Yasi = "30";  // String, Yaşı
           labSonuc.Cinsiyet = "Erkek";  // String, Cinsiyet
           labSonuc.Bolum = "İç Hastalıkları";  // String, Bölümü
            labSonuc.Hatakodu = "0";  // String, Hata kodu
            labSonuc.Hataaciklama = "Başarılı";  // String, Hata açıklaması

           // Tlabsonucprotokol dizisi oluşturuldu ve örnek veri eklendi
           labSonuc.Labsonuc = new Tlabsonucprotokol[]
           {
               new Tlabsonucprotokol
               {
                   ProtokolNo = 12345,  // Numeric, Protokol numarası
                   Sonuc = "Sonuç açıklaması"  // String, Sonuç açıklaması
               }
           };

           return labSonuc;
       }
    }
}