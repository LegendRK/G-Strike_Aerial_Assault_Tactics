using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Player
    {
        public Gundam Gundam;
        // Initialize the values to create loop conditions
        int baseModel = 100;
        int backpack = 100;

        // Take in player input to create their Gundam character
        public void AssignGundam()
        {

            // main loop to make Gundam
            while (baseModel == 100 && backpack == 100)
            {
                // Asks player for base gundam
                Console.Write("Select your Gundam Base: ");
                string strBaseModel = Console.ReadLine();
                int.TryParse(strBaseModel, out baseModel);

                // checks to make sure player entered a correct value
                if (baseModel == 0 || baseModel > 3)
                {
                    Console.WriteLine("Please enter a correct data value.");
                    baseModel = 100;
                }

                // checks to make sure player wants gundam value with no backpack
                else if (baseModel == 1)
                {
                    Console.WriteLine("This Gundam cannot equip a backpack. Are you sure you want to continue? (Y/N)");
                    string choice = Console.ReadLine().ToLower();
                    if (choice == "yes" || choice == "y")
                    {
                        backpack = 0;
                    }
                    else
                    {
                        baseModel = 100;
                    }
                }

                // if other conditions are met, user can select backpack
                else
                {
                    // asks the user for the backpack value
                    Console.Write("Select your backpack: ");
                    string strBackpack = Console.ReadLine();
                    int.TryParse(strBackpack, out backpack);

                    // checks to make sure user wants no backpack or if they entered invalid value
                    if (backpack == 0)
                    {
                        Console.WriteLine("You are selecting no backpack. Is this ok? (Y/N)");
                        string choice = Console.ReadLine().ToLower();
                        // makes loop run again if they want to change
                        if (choice == "yes" || choice == "y")
                        {
                            backpack = 0;
                        }
                        else
                        {
                            backpack = 100;
                            baseModel = 100;
                        }
                    }
                    else if (backpack > 3)
                    {
                        Console.WriteLine("Please enter a valid backpack value!");
                        backpack = 100;
                        baseModel = 100;

                    }

                }

            }
            Gundam = Gundam.GundamList[baseModel - 1];
            




        }
    }
}
