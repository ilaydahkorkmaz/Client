using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.MedReference;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            Tkimlik kimlik = new Tkimlik();
            kimlik.tckimlik_no = "61468458574";
            kimlik.adi = "ilayda";
            kimlik.soyadi = "korkmaz";
            kimlik.Email = "ilaydahkorkmaz@gmail.com";
            kimlik.anne_adi = "x";
            kimlik.baba_adi = "hasan";
            kimlik.dogumtarihi = DateTime.Now.ToString();


            Tistekler tistekler = new Tistekler();
            tistekler.sira_no = 1;
            tistekler.tarih = "26.08.2024";
            tistekler.kodu = 4343;
            tistekler.exkodu = "EK123";
            tistekler.aciklama = "Tetkik Açıklaması";
            tistekler.girisyapan = "İlayda Korkmmaz";
            tistekler.hastane_rowid1 = "Unique123";
            tistekler.acilmi = "";
            tistekler.tarih = DateTime.Now.ToString();

            //istekler.aciklama = "Açıklama";
            //istekler.kodu = 4323;

            TIstekSonuc ıstekSonuc = new TIstekSonuc();
            ıstekSonuc.DosyaNo = 124;
            ıstekSonuc.TC_kimlik_no = 122345567;
            ıstekSonuc.hatakodu = 0;
            ıstekSonuc.meddatateslimNo = 23324;
            ıstekSonuc.kabuledilenler = "1,2,3";

       


            Tistekgiris istekGiris = new Tistekgiris();
            istekGiris.kimlik = kimlik;
           
           // istekGiris.istekler = istekler;
            //  istekyapRequest istekyap = new istekyapRequest();
            // istekyap.kullanici = Base64Encode("ilayda");
             //istekyap.kullanici = Base64Encode("ilayda");


            // MeddataLabServiceClient nesnesini oluştur
            MeddataLabServiceClient meddataLabServiceClient = new MeddataLabServiceClient();

            // istek yapma işlemini hazırlayın
            istekyapRequest istekyap = new istekyapRequest();
            //istekyap.kullanici = "ilayda";
            //istekyap.sifre = "ilayda";

         
            // istekyap metodunu çağırarak isteği yapın
            TIstekSonuc isteksonuc = meddataLabServiceClient.istekyap(Base64Encode("doga"), Base64Encode("doga"), 212,"LAB",istekGiris);
            TLoginSonuc  lsonuc =  meddataLabServiceClient.Login(Base64Encode("doga"), Base64Encode("doga"));
            // Sonuç mesajını göster

           



            int a = meddataLabServiceClient.test(Base64Encode("dogad"), Base64Encode("doga"), "demo");
            MessageBox.Show(a.ToString());


        }
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }


       
        }

    }






//-------------------------------------------------------------------------------------------------

//    
//----------------------------------------------------------------------------------

//----------------------------------------------------------------------------------------

//public class Tlabsonucprotokol
//{
//    // İstek tarihi
//    public string Istektarihi { get; set; } // Gerekli (E)

//    // Rapor tarihi
//    public string Raportarihi { get; set; } // Gerekli (E)

//    // Rapor adı
//    public string Raporadi { get; set; } // Gerekli (E)

//    // İstek No
//    public string Istekno { get; set; } // Gerekli (E)

//    // TLabsonucdetay tablosu (Sonuçlar)
//    public List<TLabsonucdetay> Sonuclar { get; set; } // Gerekli (E)

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


//---------------------------------------------------------------------------------------


//public class TLabsonucdetay
//{
//    // İstek No
//    public double ISTEK_NO { get; set; } // Gerekli (E)

//    // Tetkik kodu
//    public double ISLEM_KODU { get; set; } // Gerekli (E)

//    // Tetkik Adı (örneğin: Hemoglobin)
//    public string ISLEM_ADI { get; set; } // Gerekli (E)

//    // Tetkik Kısa Adı (örneğin: Hb)
//    public string ISLEM_KISA_ADI { get; set; } // Gerekli (E)

//    // Sonuç
//    public string SONUC { get; set; } // Gerekli (E)

//    // Ünite
//    public string UNITE { get; set; } // Gerekli (E)

//    // Min-Max Değerler
//    public string MINMAX { get; set; } // Gerekli (E)

//    // Aralık (Örneğin: Negatif)
//    public string ARALIK { get; set; } // Gerekli (E)

//    // Açıklama
//    public string ACIKLAMA { get; set; } // Gerekli (E)

//    // Ayrıntı Testi (örneğin: Hemogram grubu)
//    public int AYRINTI_GR { get; set; } // Gerekli (E)

//    // Hastane Row ID
//    public string HASTANE_ROWID1 { get; set; } // Gerekli (E)

//    // Entegrasyon Kodu
//    public string HASTANE_OPTIK { get; set; } // Gerekli (E)

//    // Tetkik Sıra No
//    public int SIRA { get; set; } // Gerekli (E)
//}