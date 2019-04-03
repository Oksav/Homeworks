using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesInterfaceses.Interfaces;


namespace ClassesInterfaceses.Classes
{
   public class ProFighter : Fighter , IStreet , IBox
    {
        
        public int Experience { get; set; }

        public ProFighter(double health, double powerPunch, double speed, int experience) : base (health, powerPunch, speed)
        {
            this. Experience = experience;
        }

        public override void TakeDamage(double damage)
        {
            Health = Health - damage;
        }

        public override void TakeDamage()
        {
            Health = 0;
        }
        public override bool IsDizzy()
        {
            Console.WriteLine(Health);
            if (Health < 20)
            {
                return true;
            }
            else
                return false;
        }


        protected override void Finisher(Fighter opponent)
        {
            TakeDamage();
            Console.WriteLine("{0} is finished.", opponent);
        }

        public void DoStreet(Fighter opponent)
        {
            double damage = PowerPunch + Experience + Speed;
            if (opponent.IsDizzy() == false)
            {
                opponent.TakeDamage(damage);
                Console.WriteLine($" {opponent} took {damage} damage!");
            }
            else if (opponent.IsDizzy() == true)
            {
                Finisher(opponent);
            }
        }

        public void DoBoxing(Fighter opponent)
        {
            double damage = PowerPunch + Experience + Speed;
            if (opponent.IsDizzy() == false)
            {
                opponent.TakeDamage(damage);
                Console.WriteLine($" {opponent} took {damage} damage!");
            }
            else if (opponent.IsDizzy() == true)
            {
                Finisher(opponent);
            }
        }


    }
}
