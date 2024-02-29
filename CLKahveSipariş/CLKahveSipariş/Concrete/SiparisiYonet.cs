using CLKahveSipariş.Entities;
using CLKahveSipariş.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLKahveSipariş.Concrete
{
    public delegate void HaberTipi(object sender);
    public delegate void SiparisHaberTipi(object sender);
    public class SiparisiYonet
    {
        private List<Calisan> calisanlar;
        private List<Siparis> siparisler;
        private Envanter envanter;


        public SiparisiYonet()
        {
            calisanlar = new List<Calisan>();
            {
                new Calisan { CalisanId = 1, Adi = "Ahmet", Soyadi = "Demir", Durumu = CalismaDurumu.Calisiyorum, CalismaYeri = CalismaYeri.Kasa };
                new Calisan { CalisanId = 1, Adi = "Zeynep", Soyadi = "Avcı", Durumu = CalismaDurumu.Calisiyorum, CalismaYeri = CalismaYeri.Barista };
                new Calisan { CalisanId = 1, Adi = "Mustafa", Soyadi = "Şen", Durumu = CalismaDurumu.Bosta, CalismaYeri = CalismaYeri.Yok };
            }

            siparisler = new List<Siparis>();
            {
                new Siparis { Id = 1, UrunAdi = "Kahve",HazirlamaSuresi=5 };
                new Siparis { Id = 2, UrunAdi = "Çay", HazirlamaSuresi =3 };
                new Siparis { Id = 3, UrunAdi = "Latte", HazirlamaSuresi = 8 };
            }

            envanter = new Envanter
            {
                SurupMiktari = 30,
                SogukSutMiktari = 40,
                SicakSutMiktari = 15

            };
            void IsAkisiniBaslat()
            {
                foreach (var siparis in siparisler)
                {
                    Calisan bosCalisan = BosCalisanAl();
                    if (bosCalisan != null)
                    {
                        CalisanaSiparisAta(siparis, bosCalisan);
                        EnvanteriGuncelle(siparis);
                    }
                    else
                    {
                        Console.WriteLine("Boş çalışan yok. Kullanılabilirlik bekleniyor.");
                    }
                }
                Calisan BosCalisanAl()
                {
                    return calisanlar.FirstOrDefault(c => c.Durumu == CalismaDurumu.Bosta);
                }
            }

            void CalisanaSiparisAta(Siparis siparis, Calisan calisan)
            {
                Console.WriteLine($"Sipariş {siparis.Id} çalışana {calisan.CalisanId} atanıyor.");
                
                int isSuresi = SiparisSüresiHesapla(siparis);

                System.Threading.Thread.Sleep(isSuresi * 1000);

                calisan.Durumu = CalismaDurumu.Bosta;
            }

            int SiparisSüresiHesapla(Siparis siparis)
            {
                int SiparisSüresi = siparis.HazirlamaSuresi;
                return SiparisSüresi;
            }


            void EnvanteriGuncelle(Siparis siparis)
            {
                
                envanter.SurupMiktari -=1;
                envanter.SogukSutMiktari -= 1;
                envanter.SicakSutMiktari -= 1;


            }
        }


    }
}
