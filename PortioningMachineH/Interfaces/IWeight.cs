using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PortioningMachineH.Classes;

namespace PortioningMachineH.Interfaces
{
    public interface IWeight
    {
        int GetWeight(Item item);
    }
}
