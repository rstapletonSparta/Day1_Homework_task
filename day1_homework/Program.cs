using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameComponents;

namespace DayOneHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            Ork ork1 = new Ork();

            //ork1.PrintMethod();
            DarkWizard darkWizard = new DarkWizard();
            //darkWizard.PrintMethod();
            NPC npc2 = new DarkWizard();
            //npc2.PrintMethod();

            NPC[] ncps =
            {
                new DarkWizard(),
                new Enemy(),
                new DarkWizard(),
                new NPC()
            };
            ncps[0].PrintMethod();
            ncps[1].PrintMethod();
            ncps[2].PrintMethod();
            ncps[3].PrintMethod();
            
            Console.ReadLine();
        }
    }
}