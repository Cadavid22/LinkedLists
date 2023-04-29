using System;
using System.Runtime.ConstrainedExecution;

namespace LinkedList.logic
{
    public class YourLinkedList
    {
        private DoubleNode? _first { get; set; }
        private DoubleNode? _last { get; set; }

        public bool IsEmpty => _first == null;

        public override string ToString()
        {
            var output = string.Empty;
            var pointer = _first;
            while (pointer != null)
            {
                output += $"{pointer.Data}\n";
                pointer = pointer.Right;
            }
            return output;
        }

        public void Add(CarList carList)
        {
            DoubleNode newNode = new DoubleNode { Data = carList };
            if (IsEmpty)
            {
                _first = newNode;
                _last = newNode;
            }
            else
            {
                newNode.Left = _last;
                _last.Right = newNode;
                _last = newNode;
            }
        }

        public YourLinkedList GetBrand(string brand)
        {
            YourLinkedList brandList = new YourLinkedList();
            DoubleNode pointer = _first;
            while (pointer != null)
            {
                if (pointer.Data.Brand == brand)
                {
                    brandList.Add(pointer.Data);
                }
                pointer = pointer.Right;
            }
            return brandList;
        }

        public YourLinkedList GetYear(int lower, int upper)
        {
            YourLinkedList modelList = new YourLinkedList();
            DoubleNode pointer = _first;
            while (pointer != null)
            {
                if (pointer.Data.Year >= lower && pointer.Data.Year <= upper)
                {
                    modelList.Add(pointer.Data);
                }
                pointer = pointer.Right;
            }
            return modelList;
        }

        public YourLinkedList GetPrice(decimal lower, decimal upper)
        {
            YourLinkedList priceList = new YourLinkedList();
            DoubleNode pointer = _first;
            while (pointer != null)
            {
                if (pointer.Data.Price >= lower && pointer.Data.Price <= upper)
                {
                    priceList.Add(pointer.Data);
                }
                pointer = pointer.Right;
            }
            return priceList;
        }

        public YourLinkedList GetSeveralFilters(string brand, string model, string color, int minimumYear, int maximumYear)
        {
            YourLinkedList filteredList = new YourLinkedList();
            DoubleNode pointer = _first;
            while (pointer != null)
            {
                bool match = (brand == "*" || pointer.Data.Brand == brand) &&
                             (model == "*" || pointer.Data.Model == model) &&
                             (color == "*" || pointer.Data.Color == color) &&
                             (pointer.Data.Year >= minimumYear) &&
                             (pointer.Data.Year <= maximumYear);
                if (match)
                {
                    filteredList.Add(pointer.Data);
                }
                pointer = pointer.Right;
            }
            return filteredList;
        }

        public CarList[] GetMinMax(YourLinkedList list)
        {
            CarList[] carListMaxMin = new CarList[2];
            DoubleNode pointer = list._first;
            carListMaxMin[0] = pointer.Data;
            carListMaxMin[1] = pointer.Data;

            while (pointer != null)
            {
                if (pointer.Data.Price < carListMaxMin[0].Price)
                {
                    carListMaxMin[0] = pointer.Data;
                }
                if (pointer.Data.Price > carListMaxMin[1].Price)
                {
                    carListMaxMin[1] = pointer.Data;
                }
                pointer = pointer.Right;
            }

            return carListMaxMin;
        }
    }
}