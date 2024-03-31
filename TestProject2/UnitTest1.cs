using lab4WinForms;
namespace TestProject2
{
    [TestClass]
    public class UnitTest1 : AdminWindow
    {
        private void DeleteTestObject(ProductContext context)
        {
            //удалим тестовую запись
            Product testProduct = context.Products.OrderBy(e => e.Id).Last();
            if (testProduct != null)
            {
                //удаляем объект
                context.Products.Remove(testProduct);
                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestAdd()
        {
            using (var context = new ProductContext())
            {
                int countbefore = context.Products.Count();
                AddButton_Click(sender, e);
                int countafter = context.Products.Count();

                Assert.AreNotEqual(countbefore, countafter);

                DeleteTestObject(context);

            }
        }

        [TestMethod]
        public void TestUpdate()
        {
            using (var context = new ProductContext())
            {

                ChangeButton_Click(sender, e);

                Assert.IsTrue(context.Products.Any(n => n.Name == "testName2"));
                DeleteTestObject(context);

            }
        }
        [TestMethod]
        public void TestDelete()
        {
            using (var context = new ProductContext())
            {
                int countbefore = context.Products.Count();
                DeleteButton_Click(sender, e);
                int countafter = context.Products.Count();
                Assert.AreEqual(countbefore, countafter);
            }

        }
        [TestMethod]
        public void TestSelect()
        {
            LoadProducts();
            int notEmpty = AdminWindow.ProductListView.Items.Count;
            Assert.AreNotEqual((int)0, notEmpty);


        }















        object sender = new object();
        EventArgs e = new EventArgs();
        public override void AddButton_Click(object sender, EventArgs e)
        {
            using (var context = new ProductContext())
            {
                Product newproduct = new Product { Name = "Новый товар", Image = "https://content.presspage.com/uploads/1369/1920_istock-1216828053-2.jpg?10000", Price = 0 };
                context.Products.Add(newproduct);
                context.SaveChanges();
            }
        }
        public override void ChangeButton_Click(object sender, EventArgs e)
        {
            if (1 > 0)
            {

                var selected = new Product { Name = "testName", Image = "https://content.presspage.com/uploads/1369/1920_istock-1216828053-2.jpg?10000", Price = 0 };

                using (var context = new ProductContext())
                {
                    context.Products.Add(selected); context.SaveChanges(); //создадим тестовый объект
                    Product? product = null;
                    product = context.Products.OrderBy(e => e.Id).Last();
                    if (product != null)
                    {
                        product.Name = "testName2";
                        product.Price = 0;
                        product.Image = "https://content.presspage.com/uploads/1369/1920_istock-1216828053-2.jpg?10000";
                        context.SaveChanges();
                    }



                }

            }
        }
        public override void DeleteButton_Click(object sender, EventArgs e)
        {

            //создадим тестовый объект
            Product newproduct = new Product { Name = "testobject", Image = "https://content.presspage.com/uploads/1369/1920_istock-1216828053-2.jpg?10000", Price = 0 };
            using (var context = new ProductContext())
            {
                context.Products.Add(newproduct);
                context.SaveChanges();
            }

            if (1 > 0)
            {
                var selected = newproduct;
                using (var context = new ProductContext())
                {
                    Product? product = null;
                    product = context.Products.OrderBy(e => e.Id).Last();
                    if (product != null)
                    {
                        context.Products.Remove(product);
                        context.SaveChanges();
                    }
                }
                //LoadProducts();
            }
        }
    }
}