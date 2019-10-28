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
            ork1.health = 10;

            Console.WriteLine(ork1);
        }
    }
}
namespace GameComponents
{
    class Player
    {
        private double health;

        private double mana;
        private double magicDamage;

        private double rageMeter;
        private double oneHandDamage;
    }
    class NPC
    {
        private Player player;        
    }
    class Enemy : NPC
    {
        public double health;
    }
    class Ork : Enemy
    {
        private double rageMeter;
        private double oneHandDamage;
    }
    class DarkWizard : Enemy
    {
        private double mana;
        private double magicDamage;
    }
    class LightWizard : NPC
    {
        private double mana;
        private double magicDamage;
    }
}