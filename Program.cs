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
                Console.WriteLine("Lucka 1: Japp");
                Console.WriteLine("Lucka 2: Daim");
                Console.WriteLine("Lucka 3: Marabou");
                Console.WriteLine("Lucka 4: Pigall");
                string choise = Console.ReadLine();
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
                        
                }
            }       
        }
    }
}