using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_3_Camilla
{
    public class MenuCatalog:IMenuCatalog
    {
        //Definer en collection (List eller Dictionary) til at indeholde supertypen, dvs IMenuItem.
        private List<IMenuItem> menuCatalogs;
        public MenuCatalog()
        {
            menuCatalogs = new List<IMenuItem>();

        }
        public int Count { get; }

        public void Add(IMenuItem aMenuItem)
        {
            List<int> menuIds= new List<int>();

            foreach (var menuIt in menuCatalogs)
            {
                menuIds.Add(menuIt.Id);
            }
            if (menuIds.Count != 0)
            {
                int start = menuIds.Max();
                aMenuItem.Id = start + 1;
            }
            else
            {
                menuIt.Id = 1;
            }
            menuCatalogs.Add(aMenuItem);
        }
    }
        public IMenuItem Search(int number)
        {
            return null;
        }
        public void Delete(int number)
        {
            
        }
        public void PrintPizzasMenu()
        {

        }
        public void PrintBeveragesMenu()
        {

        }
        public void PrintToppingsMenu()
        {

        }

        public void Update(int number, IMenuItem theMenuItem)
        {

        }
        public List<IMenuItem> FindAllVegan(MenuType type)
        {
            //her skal laves en liste. All vegan items should be added to the returt list.
            List<IMenuItem > returnList = new List<IMenuItem>();
            //foreach () { } //this was suggested by the program, look at it.Because my brain says that would work.
            return returnList;
        }
        public List<IMenuItem> FindAllOrganic(MenuType type)
        {
            return null;
        }
        public IMenuItem MostExpensiveMenuItem()
        {
            return null;
        }
    }
}
