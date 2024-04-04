using lab4WinForms;
namespace TestProject2
{
    [TestClass]
    public class UnitTest1 : AdminWindow
    {

        [TestClass]
        public class ProductTests
        {
            EventArgs e = new EventArgs();
            [TestMethod]
            public void LoadProductsTest()
            {
                // Arrange
                var productForm = new AdminWindow();

                // Act
                productForm.LoadProducts();

                // Assert
                Assert.IsTrue(productForm.ProductListView.Items.Count > 0, "Не удалось загрузить продукты в ListView");
            }

            [TestMethod]
            public void AddProductsTest()
            {
                // Arrange
                var productForm = new AdminWindow();

                using (var context = new ProductContext())
                {
                    int countbefore = context.Products.Count();

                    // Act
                    productForm.AddButton_Click(productForm.AddButton, e);

                    int countafter = context.Products.Count();

                    Assert.IsTrue(countbefore != countafter, "Одно и то же кол-во товара");
                }
            }


            [TestMethod]
            public void DeleteProductsTestSelected()
            {
                // Arrange
                var productForm = new AdminWindow();
                productForm.Show();
                productForm.LoadProducts();
                productForm.ProductListView.Items[0].Selected = true;

                using (var context = new ProductContext())
                {
                    int countbefore = context.Products.Count();

                    // Act
                    productForm.DeleteButton_Click(productForm.DeleteButton, e);

                    int countafter = context.Products.Count();

                    Assert.IsTrue(countbefore != countafter, "Одно и то же кол-во товара");
                }
            }
            [TestMethod]
            public void ChangeProductsTestSelected()
            {
                // Arrange
                var productForm = new AdminWindow();
                productForm.LoadProducts();
                productForm.Show();
                productForm.ProductListView.Items[0].Selected = true;
                productForm.Nametxb.Text = "ChangedNameForTest";
                using (var context = new ProductContext())
                {
                    var product = context.Products.Where(p => p.Name == "ChangedNameForTest").First();
                    if (product != null)
                    {
                        product.Name = "Новый товар";
                        context.SaveChanges();
                    }

                    int countbefore = context.Products.Count(p => p.Name == "Новый товар");
                    Console.WriteLine(countbefore);
                    // Act
                    productForm.ChangeButton_Click(productForm.ChangeButton, e);

                    int countafter = context.Products.Count(p => p.Name == "Новый товар");
                    Console.WriteLine(countafter);
                    Assert.IsTrue((countbefore != countafter), "Одно и то же кол-во одинакого товара");
                }
            }
        }
    }
}