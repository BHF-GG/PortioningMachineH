using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PortioningMachineH.Interfaces;

namespace PortioningMachineH.Classes
{
    public class ConveyorBelt : IConveyorBelt
    {
        public List<Item> Items;
        public List<int> TotalBinWeight { get; private set; }
        private readonly IInFeeder _inFeeder;
        private readonly IWeight _weight;
        private readonly IPortioner _portioner;
        private Item _item;
        private ILog _log;
        private readonly double _targetWeight;

        public ConveyorBelt(int numberOfBins, int targetWeight)
        {
            Items = new List<Item>();
            _inFeeder = new InFeeder();
            _weight = new Weight();
            _portioner = new Portioner(numberOfBins);
            TotalBinWeight = new List<int>();
            _targetWeight = targetWeight;

            for (int i = 0; i < numberOfBins; i++)
            {
                TotalBinWeight.Add(0);
            }
        }

        public void GetItem()
        {
            _item = _inFeeder.GenerateItem();
            Items.Add(_item);
            _log.UpdateNewItem(_item);
        }

        public void MoveItemToWeight(Item item)
        {
            item.RegisteredWeight = _weight.GetWeight(item);
        }


        public void MoveItemToPortioner(int binNumber, Item item)
        {
            _portioner.ItemToBin(binNumber,item);
            TotalBinWeight[binNumber] += item.RegisteredWeight;
            Items.Remove(item);

            if (TotalBinWeight[binNumber] >= _targetWeight)
                EmptyBin(binNumber);
        }


        public void EmptyBin(int binNumber)
        {
            double testTotalWeight = TotalBinWeight[binNumber];
            double percentAbove = ((testTotalWeight-_targetWeight) / _targetWeight*100);
            _log.UpdateBinEmptied(TotalBinWeight[binNumber], binNumber, percentAbove);
            _portioner.EmptyBin(binNumber);
            TotalBinWeight[binNumber] = 0;
        }

        public void Register(ILog log)
        {
            _log = log;
        }

        public Item GetCurrentItem()
        {
            return Items[Items.Count - 1];
        }

    }
}
