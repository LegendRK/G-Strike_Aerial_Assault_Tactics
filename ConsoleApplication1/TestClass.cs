using ConsoleApplication1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu menu = new MainMenu();
            Player player = new Player();
            
            if (menu.PlayGame())
            {
                player.AssignGundam();
            }
            else
            {
                Environment.Exit(0);
            }
            Console.WriteLine(player.Gundam.name);
            
        }
        

    }

}
