using System;

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