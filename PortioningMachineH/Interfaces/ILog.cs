using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PortioningMachineH.Classes;

namespace PortioningMachineH.Interfaces
{
    public interface ILog
    {
        void UpdateNewItem(Item item);
        void UpdateBinEmptied(int totalWeight, int binNumber, double percentAbove);

        void PrintEntry();
        void PrintBin();
    }
}
