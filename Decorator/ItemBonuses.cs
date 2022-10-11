using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern1
{
    abstract class ItemBonuses: Character
    {
        protected Character? _item;

        public ItemBonuses(Character item)
        {
            this._item = item;
        }
    }
}
