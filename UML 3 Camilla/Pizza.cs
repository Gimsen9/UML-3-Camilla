using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_3_Camilla
{
    internal class Pizza: MenuItem
    {
        public Pizza(int number,
                  string name,
                  string description,
                  double price,
                  MenuType menutype,
                  bool isVegan,
                  bool isOrganic,
                  bool deepPan) : base(number,
                                          name,
                                          description,
                                          price,
                                          menutype,
                                          isVegan,
                                          isOrganic)
        {
            Number = number;
            Name = name;
            Description = description;
            Price = price;
            MenuType Type = menutype;
            IsVegan = isVegan;
            IsOrganic = isOrganic;
            DeepPan = deepPan;
        }

        public bool DeepPan { get; set; }
    }
}
