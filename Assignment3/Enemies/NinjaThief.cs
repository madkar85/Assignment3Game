using System;
using System.Collections.Generic;
using System.Text;
using Assignment3.Interfaces;

namespace Assignment3.Enemies
{
    class NinjaThief : Monster
    {

        public NinjaThief()
        {
            this.Name = "Ninja Thief";
            this.Hp = 35;
            this.ExpWhenKilled = 12;
            this.Gold = 50;
            this.Sound = "I'm gonna cut you!";
        }
        
    }
}
