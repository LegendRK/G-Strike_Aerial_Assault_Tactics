using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Gundam
    {
        public static Gundam[] GundamList = new Gundam[] {
            new Gundam("RX-78-2", 15, 8, 5, 2, 15, 0, 0, 0, 100),
            new Gundam("Freedom", 17, 9, 2, 3, 10, 30, 0, 3, 100),
            new Gundam("X", 16, 9, 0, 2, 10, 35, 1, 4, 100)
        };
        /*
        Name:
        Attack Value:
        Accuracy:
        Shield Strength:
        Movement - takes 1 energy
        Beam Rifle Energy Consumption:    
        Special Consumption (percentage):
        Special Delay (in turns):
        Special Multiplier;
        Energy (percentage): 100    
        */
        public string name;
        public int attack;
        public int accuracy;
        public int shieldStrength;
        public int movement;
        public int rifleEnergy;
        public int specialConsum;
        public int specialDelay;
        public int specialMultiplier;
        public int energy;

        public Gundam(string nm, int atk, int acc, int shield, int mov, int rifleE, int sConsum, int sDelay, int sMulti, int eng)
        {
            name = nm;
            attack = atk;
            accuracy = acc;
            shieldStrength = shield;
            movement = mov;
            rifleEnergy = rifleE;
            specialConsum = sConsum;
            specialDelay = sDelay;
            specialMultiplier = sMulti;
            energy = eng;
        }

        public Gundam AssignGundam(int id)
        {
            if (id == 1)
            {
                return GundamList[0];
            }
            else if (id == 2)
            {
                return GundamList[1];
            }
            else if (id == 3)
            {
                return GundamList[2];
            }
            return null;
            

        }

    }
}
