using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PortioningMachineH.Interfaces;

namespace PortioningMachineH.Classes
{
    public class Weight : IWeight
    {
        public int GetWeight(Item item)
        {
            return item.Weight;
        }
    }
}
