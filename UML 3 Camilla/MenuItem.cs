using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UML_3_Camilla
{
    public class MenuItem :IMenuItem
    {
        public int Number { get; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int size { get; set; }
        public MenuType Type { get; set; }
        public bool IsVegan { get; set; }
        public bool IsOrganic { get; set; }


        public MenuItem(int number,
            string name,
            double price,
            MenuType menuType,
            bool IsVegan,
            bool isOrganic)
        {

        }
        public virtual string PrintInfo()
        {
        //Implementeres Man kan kalde ToString her, da de gør det samme.
            return "Info om Menuitem";
         }
    public override string ToString()
    {
        //Implementeres.
        return base.ToString();
    }


}
}
