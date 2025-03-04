﻿using System;

namespace LinkedList.logic
{
    public class CarList
    {
        public string ?Brand { get; set; }
        public string ?Model { get; set; }
        public int Year { get; set; }
        public string ?Color { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"{Brand} {Model} {Year} {Color} - {Price}";
        }
    }
}
