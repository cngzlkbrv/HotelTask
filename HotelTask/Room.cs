using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelTask
{
    internal class Room
    {
        private static int _id;
        public int Id { get; }
        public string Name { get; set; }
        public double Price { get; set; }
        public bool IsAvailable { get; set; } = true;
        public int PersonCapasity { get; set; }


        public Room(string name,double price,int personcapasity)
        {
            _id++;
            Id = _id;
            Name = name;
            Price = price;
            PersonCapasity = personcapasity;
        }
        public  string ShowInfo()
        {
            string info = $"Adi:{Name} Qiymeti:{Price} Tutumu:{PersonCapasity} Doludur:{IsAvailable}";
            return info ;
        }
        public override string ToString()
        {
           return ShowInfo();
        }
    }
}
