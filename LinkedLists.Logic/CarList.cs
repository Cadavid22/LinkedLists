using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace LinkedLists.Logic
{
    public class CarList<T>
        
    {
        private CarList<T>? _first;

        private CarList<T>? _last;

        public CarList()
        {
            _first = null;
            _last = null;
            Count = 0;
        }

        public string Brand{ get; set }
        public int Model{ get; set }
        public int year{ get; set }
        public string Color{ get; set }
        public double Price{ get; set }
        
        public int Count { get; set; }

        public bool IsEmpty => Count == 0;
            
        
    }
}
