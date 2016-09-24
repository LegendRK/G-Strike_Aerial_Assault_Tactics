using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class MainMenu
    {
        static int selection = 0;
        public Boolean PlayGame()
        {
            while (selection != 1 || selection != 2)
            {
                Console.WriteLine("<1> Play");
                Console.WriteLine("<2> Quit");
                int.TryParse(Console.ReadLine(), out selection);
                if (selection == 1)
                {
                    return true;
                }
                else if (selection == 2)
                {
                    return false;

                }
           

            }
            return false;
        }
    }
}
