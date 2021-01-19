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
            this.Hp = 50;
            this.ExpWhenKilled = 8;
        }


    }
}
