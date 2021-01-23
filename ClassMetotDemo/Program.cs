using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();

            customer1.Name = "Joseph";
            customer1.Surname = "Alonso";
            customer1.Age = 21;

            Customer customer2 = new Customer();

            customer2.Name = "Beth";
            customer2.Surname = "Harmon";
            customer2.Age = 29;

            Customer customer3 = new Customer();

            customer3.Name = "Arsène";
            customer3.Surname = "Lupin";
            customer3.Age = 45;

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };


            foreach (Customer musteri in customers)
            {
                Console.WriteLine(musteri.Name);
                Console.WriteLine(musteri.Surname);
                Console.WriteLine(musteri.Age);

            }


            CustomerManager musteriManager = new CustomerManager();

            musteriManager.Ekle(customer1);
            musteriManager.Ekle(customer2);
            musteriManager.Ekle(customer3);

            musteriManager.Liste(customer1);
            musteriManager.Liste(customer2);
            musteriManager.Liste(customer3);


            musteriManager.Silme(customer1);
            musteriManager.Silme(customer2);
            musteriManager.Silme(customer3);


        }

    }

}



        
