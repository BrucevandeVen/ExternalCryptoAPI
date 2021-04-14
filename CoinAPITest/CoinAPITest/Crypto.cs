using System;
using System.Collections.Generic;
using System.Text;

namespace CoinAPITest
{
    class Crypto
    {
        public int id { get; set; }
        public string name { get; set; }
        public int price { get; set; }

        public override string ToString()
        {
            return "id: " + Convert.ToString(id) + " " + "name: " + name + " " + " price: " + Convert.ToString(price);
        }
    }
}
