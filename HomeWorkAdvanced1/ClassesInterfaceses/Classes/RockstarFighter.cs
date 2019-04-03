using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesInterfaceses.Interfaces;

namespace ClassesInterfaceses.Classes
{
   public class RockstarFighter : Fighter , IStreet, IBox, IMuayThai
    {
        
        public int Reputation { get; set; }



        public RockstarFighter(double health, double powerPunch, double speed, int reputation) : base (health, powerPunch, speed)
        {
            this.Reputation = reputation;
        }
        public override void TakeDamage(double damage)
        {
            Health = Health - damage;
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
            Console.WriteLine("{0} is finished.", opponent);
        }

        public void DoStreet(Fighter opponent)
        {
            double damage = PowerPunch + Reputation;
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
            double damage = PowerPunch + Reputation + Speed;
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

        public void DoMuayThai(Fighter opponent)
        {
            double damage = PowerPunch + Reputation;
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
