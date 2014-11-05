﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks
{
    public class FlyRocketPowered : IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I'm flying with rocket!");
        }
    }
}
