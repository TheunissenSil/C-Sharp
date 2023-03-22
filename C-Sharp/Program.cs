using System;

namespace C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercise 5-7 --------------------------------
            // create new Station
            //HealthStation childrensHospital = new HealthStation();

            // create two new persons
            //Person ethan = new Person("Ethan", 1, 110, 7);
            //Person peter = new Person("Peter", 33, 176, 85);

            // Try out the Persons and method Weigh
            //Console.WriteLine(ethan.name + " weight: " + childrensHospital.Weigh(ethan) + " kilos");
            //Console.WriteLine(peter.name + " weight: " + childrensHospital.Weigh(peter) + " kilos");

            // Test feeding the persons
            //childrensHospital.Feed(ethan);
            //childrensHospital.Feed(peter);

            // See that the weights have changed
            //Console.WriteLine(ethan.name + " weight: " + childrensHospital.Weigh(ethan) + " kilos");
            //Console.WriteLine(peter.name + " weight: " + childrensHospital.Weigh(peter) + " kilos");

            // Keep weighing to increase the 'int weighings'
            //childrensHospital.Weigh(ethan);
            //childrensHospital.Weigh(ethan);
            //childrensHospital.Weigh(ethan);
            //childrensHospital.Weigh(ethan);

            // See that the variable has increased to 8
            //Console.WriteLine("weighings performed: " + childrensHospital.weighings);

            // ----------------------------------------------
            //Console.WriteLine("----------------------------------------------");
            // Exercise 5-8 --------------------------------
            // Card
            //PaymentCard petesCard = new PaymentCard(10);

            //Console.WriteLine("money " + petesCard.balance);
            //bool wasSuccessful = petesCard.TakeMoney(8);
            //Console.WriteLine("successfully withdrew: " + wasSuccessful);
            //Console.WriteLine("money " + petesCard.balance);

            //wasSuccessful = petesCard.TakeMoney(4);
            //Console.WriteLine("successfully withdrew: " + wasSuccessful);
            //Console.WriteLine("money " + petesCard.balance);

            // Terminal
            //PaymentTerminal lunchCafeteria = new PaymentTerminal();
            //Console.WriteLine(lunchCafeteria);

            //PaymentCard annesCard = new PaymentCard(2);

            //Console.WriteLine("amount of money on the card is " + annesCard.balance + " euros");

            //bool wasSuccessful1 = lunchCafeteria.EatLunch(annesCard);
            //Console.WriteLine("there was enough money: " + wasSuccessful1);

            //lunchCafeteria.AddMoneyToCard(annesCard, 100);

            //wasSuccessful1 = lunchCafeteria.EatLunch(annesCard);
            //Console.WriteLine("there was enough money: " + wasSuccessful1);

            //Console.WriteLine("amount of money on the card is " + annesCard.balance + " euros");

            //Console.WriteLine(lunchCafeteria);
            // ----------------------------------------------
            Console.WriteLine("-------------------- --------------------------");
            // Exercise 5-9 --------------------------------
            Pet lucy = new Pet("Lucy", "golden retriever");
            Person leo = new Person("Leo", lucy);
            Console.WriteLine(leo);

            Pet stitch = new Pet("Stitch", "blue alien");
            Person mike = new Person("Lilo", stitch);
            Console.WriteLine(mike);

            Pet toothless = new Pet("Toothless", "dragon");
            Person lilo = new Person("Mike", toothless);
            Console.WriteLine(lilo);
            // ----------------------------------------------

        }

        public static void Opd5_9()
        {

        }
    }
}