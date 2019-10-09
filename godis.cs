using System;
namespace godisautomaten{
    public class candyType {
        public int ammount;
        static int sellCandy(int toSell, candyType candy){
            if (candy.ammount > 0){
                candy.ammount = candy.ammount -toSell;
                return candy.ammount;
            }else{
                Console.WriteLine("Det finns inte något godis kvar!");
                return 0;
            }
        }
    }
}