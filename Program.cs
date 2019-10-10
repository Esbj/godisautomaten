using System;
using System.Collections.Generic;
namespace godisautomaten
{
    class Program
    {
        public List<candyType> bag = new List<candyType>();
        static void Main(string[] args)
        {
            Japp japp = new Japp();
            Daim daim  = new Daim();
            Pigall pigall = new Pigall();
            Marabou marabou  = new Marabou();
            int jappBagCount = 0;
            int daimBagCount = 0;
            int pigallBagCount = 0;
            int marabouBagCount = 0;
            while(true){
                Console.WriteLine("Välkommen till godisautomaten!");
                Console.WriteLine("Detta godiset finns tillgängligt");
                Console.WriteLine("Lucka 1: "+japp.ammount+" Japp");
                Console.WriteLine("Lucka 2: "+daim.ammount+" Daim");
                Console.WriteLine("Lucka 3: "+marabou.ammount+" Marabou");
                Console.WriteLine("Lucka 4: "+pigall.ammount+" Pigall");
                Console.WriteLine("Vilken godis vill du köpa?");
                
                string choise = Console.ReadLine();
                Console.WriteLine("Hur många?");
                
                int toBuy = Convert.ToInt32(Console.ReadLine());
                switch (choise){
                    case "Japp":
                        japp.sellCandy(toBuy, japp);
                        break;
                    case "Daim":
                        daim.sellCandy(toBuy, daim);
                        break;
                    case "Marabou":
                        marabou.sellCandy(toBuy, daim);
                        break;
                    case "Pigall":
                        pigall.sellCandy(toBuy, pigall);
                        break;    
                    default:
                        Console.WriteLine("Ange endast godistyper som finns listade");
                        break;
                }
            }       
        }
    }
}