using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PortioningMachineH.Interfaces;

namespace PortioningMachineH.Classes
{
    public class ControlUnit
    {
        private IConveyorBelt _conveyorBelt;
        private ILog _log;
        private Item _item;
        private int _numberOfBins;
        private int _targetWeight;
        private List<int> binWeight;
        private int _index;

        public ControlUnit(int numberOfBins, int targetWeight)
        {
            _numberOfBins = numberOfBins;
            _targetWeight = targetWeight;
            _conveyorBelt = new ConveyorBelt(_numberOfBins, _targetWeight);
            _log = new Log();
            _index = 0;
            _conveyorBelt.Register(_log);
        }

        public void Run()
        {
            _conveyorBelt.GetItem();
            _item = _conveyorBelt.GetCurrentItem();
            _conveyorBelt.MoveItemToWeight(_item);
            _conveyorBelt.MoveItemToPortioner(CalculateDestination(),_item);

        }

        private int CalculateDestination()
        {

            if (_index < _numberOfBins - 1)
                ++_index;
            else
            {
                _index = 0;
            }

            return _index;
        }

        public void PrintEntry()
        {
            _log.PrintEntry();
        }

        public void PrintBin()
        {
            _log.PrintBin();
        }
    }
}
