using System;
using System.Collections.Generic;
namespace godisautomaten{
    
    public class candyType {
        public List<candyType> bag = new List<candyType>();
        public int ammount;
         public void addToBag(candyType candy, int ammount){
            if (ammount > 0){
                bag.Add(candy);
            }
        }
        public int sellCandy(int toSell, candyType candy){
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