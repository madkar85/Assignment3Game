using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3.Enemies 
{
    class Goblin : Monster
    {

        public Goblin()
        {
            this.Name = "Goblin";
            this.Hp = 25;
            this.ExpWhenKilled = 7;
            this.Gold = 30;
            this.Sound = "iiiiIIIIeeeehhhhh";
        }
    }
}
