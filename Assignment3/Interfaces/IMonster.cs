using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3.Interfaces
{
    interface IMonster
    {

       public void TakeDamage(int damage);

       public void SetMonsterToughness(Player player);

       // public void StrongerMonster(); Monster blir starkare när player levlar upp

    }
}
