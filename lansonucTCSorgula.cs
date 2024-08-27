public TLabsonuc labsonucTC_NO(
   string kullanici,
   string sifre,
   string tarihbas,
   string tarihbit,
   double tc_kimlik_no,
   double hastane_no)
{
    // Örnek bir nesne oluşturuluyor
   TLabsonuc sonuc = new TLabsonuc();
 Burada genellikle bir servise istek gönderirsiniz.
 Aşağıdaki kod sadece örnek olarak verilmiştir.

 Veritabanı veya servisten veri çekme kodları
 Bu kod, gerçek bir uygulamada API çağrısı veya veritabanı sorgusu içerebilir.

Örnek veri doldurma
    sonuc.Adisoyadi = "Ali Veli";
    sonuc.Yasi = "45";
    sonuc.Cinsiyet = "Erkek";
    sonuc.Bolum = "Genel";
    sonuc.Hatakodu = "0";
    sonuc.Hataaciklama = "Başarılı";
    sonuc.Labsonuc = new List<TLabsonucprotokol>
    {
       new TLabsonucprotokol
       {
           Istektarihi = "01.01.2024",
           Raportarihi = "02.01.2024",
            Raporadi = "Rapor 1",
           Istekno = "123456",
           Sonuclar = new List<TLabsonucdetay>
           {
              new TLabsonucdetay
              {
                    ISTEK_NO = 123,
                    ISLEM_KODU = 456,
                   ISLEM_ADI = "Hemoglobin",
                    ISLEM_KISA_ADI = "Hb",
                    SONUC = "14.0",
                    UNITE = "g/dL",
                    MINMAX = "13-17",
                    ARALIK = "Normal",
                    ACIKLAMA = "Normal değerler",
                    AYRINTI_GR = 1,
                    HASTANE_ROWID1 = "UNIQUE123",
                    HASTANE_OPTIK = "Kod123",
                   SIRA = 1
               }
           },
           Sonucdurumu = "Tamamlandı",
           Grup_testi = "Kan Testi",
           Hata_kodu = "0",
           Hata_aciklama = "Başarılı",
           Rapportext = "Rapor metni burada yer alır"      
             }
   };

   return sonuc;}
