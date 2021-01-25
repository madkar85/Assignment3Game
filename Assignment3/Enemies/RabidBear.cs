using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3.Enemies 
{
    class RabidBear : Monster
    {

        public RabidBear()
        {

            this.Name = "Rabid Bear";
            this.Hp = 30;
            this.ExpWhenKilled = 8;
            this.Gold = 40;
            this.Sound = "RAAAAAAAWWWWWWWWRRRRRRR";

        }


    }
}
