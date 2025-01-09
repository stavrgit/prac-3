using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac_3
{
    public class Laptop: IComparable<Laptop>//ICloneable
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }

        public Laptop(string brand, string model, double price)
        {
            Brand = brand;
            Model = model;
            Price = price;
        }

        public int CompareTo(Laptop laptop)
        {
            if (laptop == null) throw new ArgumentNullException();
            return Price.CompareTo(laptop.Price);
        }


        public object Clone()
        {
            return new Laptop(this.Brand, this.Model, this.Price);
        }

        internal static void Sort()
        {
            throw new NotImplementedException();
        }
    }
}
