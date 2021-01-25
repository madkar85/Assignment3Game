using System;
using System.Collections.Generic;
using System.Text;
using Assignment3.Interfaces;

namespace Assignment3.Enemies
{
    class GiantSpider : Monster
    {

        public GiantSpider()
        {
            this.Name = "Giant Spider";
            this.Hp = 40;
            this.ExpWhenKilled = 10;
            this.Gold = 60;
            this.Sound = "*swish swish* You look like a nice dinner!";
        }


    }
}
