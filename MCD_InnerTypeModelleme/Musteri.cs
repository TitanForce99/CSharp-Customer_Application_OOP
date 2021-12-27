using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_InnerTypeModelleme
{
    public class Musteri
    {
        #region Tekil olarak kullanılan özellik ler
        public int musteriID { get; set; }
        public string tcKimlikNumarasi { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public DateTime olusturmaTarih { get; set; }
        public int kullaniciId { get; set; }
        #endregion

        #region Inner Type gerektiren alan lar
        public MusteriAdres[] musteriAdresleri;
        public MusteriIletisimBilgisi[] musteriIletisimBilgileri;
        public MusteriSiparisBilgisi[] musteriSiparisBilgileri;

        public Musteri()
        {
            musteriAdresleri = new MusteriAdres[5];
            musteriIletisimBilgileri = new MusteriIletisimBilgisi[3];
            musteriSiparisBilgileri = new MusteriSiparisBilgisi[10];
        }
        #endregion



    }
}
