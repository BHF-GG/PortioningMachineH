using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PortioningMachineH.Classes;

namespace PortioningMachineH.Interfaces
{
    public interface IConveyorBelt
    {
        void GetItem();
        void MoveItemToWeight(Item item);

        void MoveItemToPortioner(int binNumber, Item item);

        void EmptyBin(int binNumber);

        void Register(ILog log);

        Item GetCurrentItem();

    }
}
