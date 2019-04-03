using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesInterfaceses.Interfaces;

namespace ClassesInterfaceses.Classes
{
   public class StreetFighter : Fighter, IStreet
    {
        
        public double StreetCredit { get; set; }
        
       public StreetFighter(double health, double powerPunch, double speed,int street) : base (health, powerPunch,speed)
        {
            this.StreetCredit = street;
        }

        public override void TakeDamage()
        {
            Health = 0;
        }

        public override void TakeDamage(double damage)
        {
            Health -= damage;
        }

        public override bool IsDizzy()
        {
            Console.WriteLine(Health);
            if (Health < 10)
            {
                return true;
            } else
            return false;
        }

        protected override void Finisher(Fighter opponent)
        {
            TakeDamage();
            Console.WriteLine($"{opponent} is finished.");
        }



        public void DoStreet(Fighter opponent)
        {
           double damage = PowerPunch + StreetCredit + Speed;
            if (opponent.IsDizzy() == false)
            {
                
                opponent.TakeDamage(damage);
                Console.WriteLine($" {opponent} took {damage} damage!");
            }
            else if(opponent.IsDizzy() == true)
            {
                Finisher(opponent);
            }
        }

    }
}
