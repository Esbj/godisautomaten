using System;

namespace godisautomaten
{
    class Program
    {
        static void Main(string[] args)
        {
            Japp japp = new Japp();
            Daim daim  = new Daim();
            Pigall pigall = new Pigall();
            Marabou marabou  = new Marabou();
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
                
                int ammount = Convert.ToInt32(Console.ReadLine());
                switch (choise){
                    case "Japp":
                        japp.sellCandy(ammount, japp);
                        break;
                    case "Daim":
                        daim.sellCandy(ammount, daim);
                        break;
                    case "Marabou":
                        marabou.sellCandy(ammount, daim);
                        break;
                    case "Pigall":
                        pigall.sellCandy(ammount, pigall);
                        break;    
                    default:
                        Console.WriteLine("Ange endast godistyper som finns listade");
                        break;
                }
            }       
        }
    }
}