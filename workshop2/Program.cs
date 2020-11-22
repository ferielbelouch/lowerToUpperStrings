using System;

namespace workshop2
{
    class Program
    {
        static void Main(string[] args)
        {


            //  Console.Write("Ecrire un message : ");
            //   string msg = Console.ReadLine();
            //   Console.WriteLine(msg.ToUpper()); //ToUpper rend tout en majuscule

            Controller.Controller c = new Controller.Controller();
            c.lowerToUper();

            
        }
    }
}
