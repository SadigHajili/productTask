using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            string cavab="he";


            Milk[] arr = new Milk[0];
            while (cavab == "he")
            {
                int price, count, volume, fatrate;
                string name;

               
                Array.Resize<Milk>(ref arr, arr.Length + 1);
                Console.WriteLine("Count: ");
                count = int.Parse(Console.ReadLine());
                Console.WriteLine("Price: ");
                price = int.Parse(Console.ReadLine());
                Console.WriteLine("Volume: ");
                volume = int.Parse(Console.ReadLine());
                Console.WriteLine("Fatrate: ");
                fatrate = int.Parse(Console.ReadLine());
                Console.WriteLine("Product Name: ");
                name = Console.ReadLine();
                arr[arr.Length - 1] = new Milk(price, name, count, volume, fatrate);
                Console.WriteLine("Davam Etmek Isdeyirsiniz ?: (he/yox)");
                cavab = Console.ReadLine();


            }
           
            foreach(var i in arr)
            {
                Console.WriteLine("Product Name: " + i.name);
                Console.WriteLine("Price : " + i.price);
                Console.WriteLine("FatRate: " + i.FatRate);
            }



        }
    }
    class Product
    {
        public string name;
        public int price;
        int count;
        int totalincome=0;

 

        public Product(string name, int price, int count)
        {
            this.name = name;
            this.price = price;
            this.count = count;
      

        }
        public void Sell()
        {
            if (this.count > 0)
            {
                this.count = this.count - 1;
                this.totalincome +=this.price;

            }else
            {
                Console.WriteLine("bitdi");
            }
        }
        

    }
    class Milk:Product
    {
        int Volume;
        public int FatRate;

        public Milk(int price, string name, int count, int Volume, int FatRate) : base(name, price,count)
        {
            this.Volume = Volume;
            this.FatRate = FatRate;

        }
    }
}