using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Minesweeper
{
    class MayinTarlasi
    {
        Size buyukluk_;
        List<Mayin> mayinlar;
        int dolu_mayin_sayisi;
        Random rnd = new Random();
        public MayinTarlasi(Size buyukluk, int mayin_Sayisi)
        {
            mayinlar = new List<Mayin>();
            buyukluk_ = buyukluk;
            dolu_mayin_sayisi = mayin_Sayisi;
            for (int x = 0; x < buyukluk.Width; x=x+20)
            {


                for (int y = 0; y < buyukluk.Height; y=y+20)
                {
                    Mayin m = new Mayin(new Point(x, y)); 
                    Mayin_ekle(m);
                }
            }
            Mayinlari_doldur(); 
        }
        public Size buyuklugu 
        {
            get
            {
                return buyukluk_;
            }
        }

        public void Mayin_ekle(Mayin m)
        {
            mayinlar.Add(m);
        }
        public Mayin Mayin_al_location(Point Location)
        {
            foreach (Mayin item in mayinlar)
            {
                if (item.konum_al == Location)
                {
                    return item;
                }
            }
            return null; 
           
        }
        public List<Mayin> GetAllMayin
        {
            get
            { 
                return mayinlar;
            }
        }

        private void Mayinlari_doldur()
        {
            int sayi = 0;
            while (sayi < dolu_mayin_sayisi)
            {
                int i = rnd.Next(0, mayinlar.Count);
                Mayin item = mayinlar[i];
                if(item.mayin_var_mi == false)
                {
                    item.mayin_var_mi = true;
                    sayi++;
                }
            
            }
        }
        

    }

}
