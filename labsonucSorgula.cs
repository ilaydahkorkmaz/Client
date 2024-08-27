namespace MedEntegre.Controllers
{
public class TLabsonuc
{
   public double Teslim_no { get; set; }  // Numeric (double)
   public double? Protokol_no { get; set; }  // Numeric (Opsiyonel, nullable double)
   public double? Istek_no { get; set; }  // Numeric (Opsiyonel, nullable double)
   public double? Id_no { get; set; }  // Numeric (Opsiyonel, nullable double)
   public double? Hastane_no { get; set; }  // Numeric (Opsiyonel, nullable double)
    public string HataAciklama { get; set; }  // String, Hata açıklaması (varsa)
}

   public class HomeController : Controller
   {
  public TLabsonuc LabSonucSorgulama(string adi, string soyadi, string kullanici, string sifre, double? protokol_no, double teslim_no, double? istek_no, double? id_no, double? hastane_no)
       {
           // TLabsonuc nesnesi oluşturuldu
            TLabsonuc labSonuc = new TLabsonuc();

           // Parametrelerle veri çekme işlemi burada yapılmalıdır.
           // Aşağıdaki kod örnek bir veri atamasıdır ve gerçek verilerle değiştirilmelidir.

//            // Örnek veri atanması
            labSonuc.Teslim_no = teslim_no;  // Numeric (double)
         labSonuc.Protokol_no = protokol_no;  // Opsiyonel Numeric (double?)
           labSonuc.Istek_no = istek_no;  // Opsiyonel Numeric (double?)
           labSonuc.Id_no = id_no;  // Opsiyonel Numeric (double?)
           labSonuc.Hastane_no = hastane_no;  // Opsiyonel Numeric (double?)
           labSonuc.HataAciklama = "Başarılı";  // String, hata açıklaması (örnek)

          // Gerçek uygulamada veri çekme işlemi yapılmalıdır
           // Örneğin:
           // labSonuc = SomeService.GetLabResults(adi, soyadi, kullanici, sifre, protokol_no, teslim_no, istek_no, id_no, hastane_no);

          return labSonuc;
       }
   }
}
