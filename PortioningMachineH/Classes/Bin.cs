using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PortioningMachineH.Interfaces;

namespace PortioningMachineH.Classes
{
    public class Bin : IBin
    {
        private List<Item> _items;
        private Item item;

        public Bin()
        {
            _items = new List<Item>();
        }
        public void ReceiveItem(Item item)
        {
            _items.Add(item);
        }

        public void EmptyBin()
        {
            _items = new List<Item>();
        }
    }
}
