using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern1
{
    internal class SlownessPotion: ItemBonuses
    {
        private int speedBonus = -5;

        readonly new Character _item;

        public SlownessPotion(Character item) : base(item)
        {
            _item = item;
        }

        public override int WalkingSpeed()
        {
            return speedBonus + this._item.WalkingSpeed();
        }
    }
}
