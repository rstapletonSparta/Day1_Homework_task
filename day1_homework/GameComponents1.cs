using System;

namespace GameComponents
{
    class Player
    {
        private int health;

        private int mana;
        private int magicDamage;

        private int rageMeter;
        private int oneHandDamage;

        private int[] position = new int[2];

        public int takeDamage(int damage)
        {
            return health - damage;
        }
    }
    class NPC
    {
        private int id = 0;
        private Player player;

        //public int Id { get => id; set => id = value; }
        public void SetId(int value)
        {
            if (value > 25)
            {
               id = 25;
            } else
            {
                id = value;
            }
        }
        public int GetId()
        {
            return id;
        }
        public virtual void PrintMethod()
        {
            Console.WriteLine("This is an NPC");
        }
    }
    class Enemy : NPC
    {
        private int health;
        public int DoDamage(int damage)
        {
            return health - damage;
        }
        public override void PrintMethod()
        {
            Console.WriteLine("this is a enemy");
        }
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

        public override void PrintMethod()
        {
            Console.WriteLine("This is an Dark Wizard");
        }
    }
    class LightWizard : NPC
    {
        private double mana;
        private double magicDamage;
    }
}