﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Strategies
{
    internal class Stick: IWeapon
    {
        void IWeapon.Shoot()
        {
            Console.WriteLine("attacks with a stick");
        }
    }
}
