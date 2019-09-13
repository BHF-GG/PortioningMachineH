using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PortioningMachineH.Interfaces;

namespace PortioningMachineH.Classes
{
    public class Log : ILog
    {
        private List<String> _itemsIn;
        private List<String> _emptiedBins;

        public Log()
        {
            _itemsIn = new List<string>();
            _emptiedBins = new List<string>();
        }
        public void UpdateNewItem(Item item)
        {
            _itemsIn.Add($"Id: {item.Id}: Entered with weight {item.Weight}");
        }

        public void UpdateBinEmptied(int totalWeight, int binNumber, double percentAbove)
        {
            _emptiedBins.Add($"Bin #{binNumber} emptied with total weight of {totalWeight}, {percentAbove}% above target");
        }

        public void PrintEntry()
        {
            foreach (var item in _itemsIn)
            {
                Console.WriteLine($"{item}");
            }
        }

        public void PrintBin()
        {
            foreach (var item in _emptiedBins)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
