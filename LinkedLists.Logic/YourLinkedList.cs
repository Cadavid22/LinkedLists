using System;
using DoubleNode;

public class YourLinkedList
{
    public Node First { get; set; }
    public Node Last { get; set; }

    public void Add(Car car)
    {
        Node newNode = new Node { Value = car };
        if (First == null)
        {
            First = newNode;
            Last = newNode;
        }
        else
        {
            newNode.Previous = Last;
            Last.Next = newNode;
            Last = newNode;
        }
    }

    public YourLinkedList GetBrand(string brand)
    {
        YourLinkedList brandList = new YourLinkedList();
        Node current = First;
        while (current != null)
        {
            if (current.Value.Brand == brand)
            {
                brandList.Add(current.Value);
            }
            current = current.Next;
        }
        return brandList;
    }

    public YourLinkedList GetModel(int lower, int upper)
    {
        YourLinkedList modelList = new YourLinkedList();
        Node current = First;
        while (current != null)
        {
            if (current.Value.Year >= lower && current.Value.Year <= upper)
            {
                modelList.Add(current.Value);
            }
            current = current.Next;
        }
        return modelList;
    }

    public YourLinkedList GetPrice(decimal lower, decimal upper)
    {
        YourLinkedList priceList = new YourLinkedList();
        Node current = First;
        while (current != null)
        {
            if (current.Value.Price >= lower && current.Value.Price <= upper)
            {
                priceList.Add(current.Value);
            }
            current = current.Next;
        }
        return priceList;
    }

    public YourLinkedList GetSeveralFilters(string brand, string model, string color, int minimumYear, decimal maximumPrice)
    {
        YourLinkedList filteredList = new YourLinkedList();
        Node current = First;
        while (current != null)
        {
            bool match = (brand == "*" || current.Value.Brand == brand) &&
                         (model == "*" || current.Value.Model == model) &&
                         (color == "*" || current.Value.Color == color) &&
                         (current.Value.Year >= minimumYear) &&
                         (current.Value.Price <= maximumPrice);

            if (match)
            {
                filteredList.Add(current.Value);
            }
            current = current.Next;
        }
        return filteredList;
    }

    public Car[] GetMinMax(YourLinkedList list)
    {
        Car[] minMax = new Car[2];
        Node current = list.First;
        minMax[0] = current.Value;
        minMax[1] = current.Value;

        while (current != null)
        {
            if (current.Value.Price < minMax[0].Price)
            {
                minMax[0] = current.Value;
            }
            if (current.Value.Price > minMax[1].Price)
            {
                minMax[1] = current.Value;
            }
            current = current.Next;
        }

        return minMax;
    }
}