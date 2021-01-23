using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Net.Security;
using System.Text;


namespace Assignment3
{
    class Player
    {

        private string name;
        private int level;
        private int exp;
        private int hp = 400;
        private int gold;
        private int strength;
        private int toughness;

      

        public void TakeDamage(int damage)
        {
            if(this.Toughness > 0)
            {
                damage = damage - Toughness;
            }

            this.Hp -= damage;
            if(damage <= 0)
            {
                damage = 0;
            }


            if (Hp <= 0)
            {
                this.Hp = 0;
            }

            Console.WriteLine($"The monster hit you, dealing {damage} damage");
            Console.WriteLine($"{Name} hp: {Hp}");

           
        }

        public void IsDead()
        {

                Console.WriteLine($"You were killed!");       
           
        }

    

        public void CharacterDetails()
        {
            Console.WriteLine("* * * * * * * * * * * *");
            Console.WriteLine($"* Players name = {this.Name}");
            Console.WriteLine($"* Level: {this.Level}");
            Console.WriteLine($"* Experience points: {this.Exp}");
            Console.WriteLine($"* Health points: {this.Hp}");
            Console.WriteLine($"* Gold: {this.Gold} coins");
            Console.WriteLine($"* Strength: {this.Strength}");
            Console.WriteLine($"* Toughness: {this.Toughness}");
            Console.WriteLine("* * * * * * * * * * * *");
        }

        public void CheckLevel(Player player)
        {
            if(this.Level == 10)
            {
                Console.WriteLine("Congratulations! You reached level 10 and won the game!");
            }
            else
            {
                Console.WriteLine($"You are level {player.Level}. You have {player.Exp} exp, {player.Hp} health points and {player.Gold} gold coins.");
            }
        }
        



        public string Name { get => name; set => name = value; }
        public int Level { get => level; set => level = value; }
        public int Exp {
            get => exp;
            set {
                exp = value;
                this.Level = value / 10;
            }
        }
        public int Hp { get => hp; set => hp = value; }

        public int Gold { get => gold; set => gold = value; }
        public int Strength { get => strength; set => strength = value; }
        public int Toughness { get => toughness; set => toughness = value; }
    }
}
