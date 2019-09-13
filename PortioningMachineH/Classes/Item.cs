using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortioningMachineH.Classes
{
    public class Item
    {
        public int Weight { get; private set; }
        public int Id;
        public int RegisteredWeight;
        private readonly Random _random;
        public Item(int id)
        {
            _random = new Random(id);
            Id = id;
            RegisteredWeight = 0;
            SetWeight();
        }

        private void SetWeight()
        {
            Weight = _random.Next(50, 500);
        }
    }
}
