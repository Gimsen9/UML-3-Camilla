using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_3_Camilla
{
    internal class Beverage:MenuItem
    {
        public Beverage(int number,
                          string name,
                          string description,
                          double price,
                          MenuType menutype,
                          bool isVegan,
                          bool isOrganic)
        {
            Number = number;
            Name = name; 
            Description = description;
            Price = price;
            MenuType Type = menutype;
            IsVegan = isVegan;
            IsOrganic = isOrganic;   

        }

    
    }
}
