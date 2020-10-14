using System;
using System.Collections.Generic;

namespace Prov
{
    public class Books
    {
        private List<string> Booktypes = new List<string>() {"Normal Book", "Rare Book", "Exceedingly Rare Book", "Absolute masterpiece"};
        private List<string> condition = new List<string>() {"A Worn out ", "A well read ", "A barely scratched ", "A mint condition "};

        public List<string> OwnedBooks = new List<string>();
        private string valueCondition = "";
        private string valueRarity = ""; 
        private int value = 0;
        
        public int money = 200;
        Random generator = new Random();

        public void Sell(){
        

        }
        public void Buy(){

        }
        public int Rarity(){
        int r = generator.Next(100);
            if (r <=50){
                valueRarity = Booktypes[0];
                value = 5;
            }
            else if (r<=25){
                valueRarity = Booktypes [1];
                value = 10;
            }
            else if (r<=10){
                valueRarity = Booktypes [2];
                value = 25;
            }
            else if (r<=0){
                valueRarity = Booktypes [3];
                value = 50;
            }
        int c = generator.Next(100);
            if (c<= 50){
                valueCondition = condition [0];
                value = value * 5;
            }
            else if 
            return value;
        }
        public void name(){

        }
    }
}
