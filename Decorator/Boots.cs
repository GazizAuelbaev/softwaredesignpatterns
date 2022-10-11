using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern1
{
    internal class Boots : Character
    {
        private int currentSpeed = 8;

        public override int WalkingSpeed()
        {
            return currentSpeed;
        }
    }
}