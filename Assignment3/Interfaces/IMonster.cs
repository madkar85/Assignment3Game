using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3.Interfaces
{
    interface IMonster
    {

       public void TakeDamage(int damage, Player player);

       public void SetMonsterToughness(Player player);

        public void Noice(string sound);

       

    }
}
