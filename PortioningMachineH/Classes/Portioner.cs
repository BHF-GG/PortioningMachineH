using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PortioningMachineH.Interfaces;

namespace PortioningMachineH.Classes
{
    public class Portioner : IPortioner
    {
        public List<IBin> Bins { get; private set; }

        public Portioner(int numberOfBins)
        {
            Bins = new List<IBin>();
            for (int i = 0; i < numberOfBins; i++)
            {
                Bins.Add(new Bin());
            }
        }
        public void ItemToBin(int binNumber, Item item)
        {
            Bins.ElementAt(binNumber).ReceiveItem(item);
        }

        public void EmptyBin(int binNumber)
        {
            Bins.ElementAt(binNumber).EmptyBin();
        }
    }
}
