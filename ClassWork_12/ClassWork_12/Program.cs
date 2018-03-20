using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace ClassWork_12
{
    public class Bake

    {
        public int Temperature { get; set; }
        public string Type { get; set; }
        public virtual void Heat()
        {
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("I'm heating");
            //    Thread.Sleep(1000);
            //}
        }
    }

    public class ElectricBake : Bake
    {
        public override void Heat()
        {
            Console.WriteLine("Electric bake");
        }
    }

    public class GasBake : Bake
    {
        public override void Heat()
        {
            Console.WriteLine("Gas bake");
        }
    }

    class Ivan
    {
        public void On(Bake bake)
        {
            Console.WriteLine($"I turn {bake.Type} on");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            
            List<Bake> list = new List<Bake>();
            list.Add(new ElectricBake() { Temperature = 100, Type = "Electric" });
            list.Add(new GasBake() { Temperature = 125, Type = "Gas" });

            Ivan vanya = new Ivan();

            vanya.On(list[1]);

            //list.Add(new ElectricBake());
            //list.Add(new GasBake());



            //ElectricBake electricBake = new ElectricBake();
            //electricBake.Heat();
            //electricBake.Temperature = 200;

            //GasBake gasBake = new GasBake();
            //gasBake.Heat();
            //gasBake.Temperature = 300;


            //Human human = new Human();
            //human.Name = "Ivan Dorn";
            //human.Age = 0;
            //Console.WriteLine(human.Age);


            //List<int> list = new List<int>();
            //list.Add(5);
            //list.Add(5);
            //list.Add(5);
            //Human2 human = new Human2();
            //human.Name = "Ivan";
            //Console.WriteLine(human.GetNmberOfLetters);
        }
    }
}
