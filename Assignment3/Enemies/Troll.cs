using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Assignment3.Interfaces;

namespace Assignment3.Enemies
{
    class Troll : Monster
    {
      
        public Troll()
        {
            this.Name = "Troll";
            this.Hp = 20;
            this.ExpWhenKilled = 5;
            this.Gold = 15;
            this.Sound = "Glooorp";
        }




    }
}
