// See https://aka.ms/new-console-template for more information
using UML_3_Camilla;

Console.WriteLine("Hello, World!");

IMenuCatalog catalog = new MenuCatalog();
//Test af search
IMenuItem foundItem catalog.Search(12);
if (foundItem != null)
{
    Console.WriteLine($"Found {foundItem}");
}
//Test også alle de andre functioner sådan her.

//Test af find all vegan
List<IMenuItem> veganItems = catalog.FindAllVegan(MenuType.Pizza);
foreach (IMenuItem item in veganItems)
{
    Console.WriteLine(item.Name );
}
