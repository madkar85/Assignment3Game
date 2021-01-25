using Assignment3.Enemies;
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

      
        //Bestämmer hur stor skada spelaren tar beroende på om spelarens uthållighet
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

        //Lägger till exp poäng och kollar om man levlat upp
        public void AddExperience(int exp)
        {
            
            if (((this.Exp + exp) / 10 - this.Exp / 10) > 0)
            {
              
                Console.WriteLine($"You leveled up! You are now level {this.Level + 1}");
            }
            else
            {
                
            }

            this.Exp += exp;
            CheckLevel();
        }

        //hämtar guld från monster när man vinner en strid
        public void TakeGold(int gold)
        {
            this.Gold += gold;
        }

        //bestämmer vad som händer om spelaren dött
        public void IsDead()
        {

                Console.WriteLine($"You were killed!");       
           
        }

        //kollar vilken level spelaren har, om man vunnit än
        public void CheckLevel()
        {

            this.Level = this.Exp / 10;

            if ( this.Level == 10)
            {
                LastLevel();
            }
            else 
            {
                Console.WriteLine($"You are level {this.Level}. You have {this.Exp} exp, {this.Hp} health points and {this.Gold} gold coins.");
            }


        }
        
        //om spelaren har nått level 10 så vinner den.
        public void LastLevel()
        {
            Console.WriteLine("Congratulations! You reached level 10 and won the game!");

        }
        
        //visar spelarens specifikationer
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



        public string Name { get => name; set => name = value; }
        public int Level { get => level; set => level = value; }
        public int Exp { get => exp; set => exp = value;}
        public int Hp { get => hp; set => hp = value; }
        public int Gold { get => gold; set => gold = value; }
        public int Strength { get => strength; set => strength = value; }
        public int Toughness { get => toughness; set => toughness = value; }
    }
}
