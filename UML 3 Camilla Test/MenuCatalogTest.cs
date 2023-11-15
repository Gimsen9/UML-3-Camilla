using UML_3_Camilla;

namespace UML_3_Camilla_Test
{
 {
    [TestClass]
    public class MenuCatalogTest
    {
        MenuCatalog catalog;
        public void SetUp()
        {
            catalog = new MenuCatalog();
            //MenuItem m1 = new MenuItem()
            //catalog.Add(m1);
            //add flere menuitem
        }
        [TestMethod]
        public void Add_1MenuItem()
        {
            //Arrange
            SetUp();
            //Act
            int numbersBefore = catalog.Count;
            //MenuItem m1 = new MenuItem();
            //catalog.Add(m1);
            int numbersAfter = catalog.Count;

            //Assert
            Assert.AreEqual(numbersBefore + 1, numbersAfter);

        }
    }
}