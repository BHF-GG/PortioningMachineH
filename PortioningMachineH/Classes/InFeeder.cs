using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PortioningMachineH.Interfaces;

namespace PortioningMachineH.Classes
{
    public class InFeeder : IInFeeder
    {
        private int index;

        public InFeeder()
        {
            index = 0;
        }
        public Item GenerateItem()
        {
            return new Item(++index);
        }
    }
}
