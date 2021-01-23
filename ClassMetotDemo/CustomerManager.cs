using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
     
            public void Ekle(Customer musteriEkle)
            {
                Console.WriteLine("Müşteriniz Sisteme Eklenmiştir. : " + musteriEkle.Name + " " + musteriEkle.Surname);
            }

            public void Liste(Customer musteriListe)
            {
                Console.WriteLine("Müşterileriniz Listelenmiştir. -> " + musteriListe.Name + " " + musteriListe.Surname + "-" + musteriListe.Age );
            }

            public void Silme(Customer musteriSilme)
            {
                Console.WriteLine("Müşteriniz Sistemden Silinmiştir. : " + musteriSilme.Name + " " + musteriSilme.Surname);
            }

        }
    }
