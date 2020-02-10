using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_5
{
    class Robot
    {
        //Member Variables (Has A)
        public string name;
        public int healthLevel;
        public int powerLevel;
        public string weaponType;
        public int weaponAttackPower;
        public int damageDone;
        public int battle;
        public int staminaSpent;

        // Constructor (spawner)
        public Robot() 
        {
            this.name = name;
            int health = healthLevel;
            int energy = powerLevel;
            string weapon = weaponType;
            int attackpower = weaponAttackPower;
            int damage = damageDone;
            int fight = battle;
            int newPowerLevel = staminaSpent;

        }



        //Member Methods (Can Do)
        
      
        
        public int Strike(Random random) 
        {
            random.Next(1, 100);
            int j = random.Next(1, 100);
            

            if (j >= 65)
            {
                powerLevel -= 20;
            }
            return j = staminaSpent;
        }

        public int Hit(Random random) 
        {
            random.Next(1, 100);
            int x = random.Next(1, 100);
            

            if (x >=70) 
            {
                healthLevel -= 15;
            }
            return healthLevel;
            
        }
        public int Fight(Random random)
        {
            random.Next(1, 100);
            int y = random.Next(1, 100);

            if (y >= 60)
            {
                weaponAttackPower = 25;
            }
            else 
            {
                weaponAttackPower = 0;
            }
            return weaponAttackPower;
        }
        public int Attack(Random random)
        {
            random.Next(1, 100);
            int z = random.Next(1, 100);
            if (z >= 65)
            {
                damageDone = 50;
            }
            else 
            {
                damageDone = 0;
            }
            return damageDone;

        } 
        public int Scuffle(Random move) 
        {
            int firststrike = Strike(move);
            Console.WriteLine(firststrike);
            int firstMove = Fight(move);
            Console.WriteLine(firstMove);
            int firstHit = Attack(move);
            Console.WriteLine(firstHit);
            int staringAttributes = 100;

        }
      
    }
}
