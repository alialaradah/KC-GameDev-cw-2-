using System;

namespace CW2
{
    class Program
    {
       
        static void Main(string[] args)
        {
        // Naruto's info
        string HeroName = " Uzumaki Naruto ";
        int HeroHight = 180;
        int HeroAge = 32;
        bool HeroSuperPower = true;
            int Thebonushight = 5;
            int ThenewHeroHight = HeroHight + Thebonushight;

        // Madara's info
        string VillainName = " Uchiha Madara ";
        int VillainHight = 179;
        int VillainAge = 90;
            // bool VillainSuperPower = true;
            bool VillainSuperPower = false;



        int ageDifference = VillainAge - HeroAge;





            Console.WriteLine(" Our Hero Name is " + HeroName + "and he is " + HeroAge + " years old, ");
            Console.WriteLine(" his hight is " +ThenewHeroHight + " cm"+" and he got a " + HeroSuperPower + " SuperPower!"); 
            







            Console.WriteLine(" One of the strongest enemies that Naruto fought is "+ VillainName + " and his real age is " + VillainAge +" years old, ");
            Console.WriteLine(" his hight is " + VillainHight + "cm and he got a " + VillainSuperPower + " SuperPowers!");


            Console.WriteLine(" the age difference between them is " + ageDifference + " years old");
        }
    }
}
