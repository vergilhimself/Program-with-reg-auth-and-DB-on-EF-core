using System.Net;
namespace lab4WinForms
{
    public partial class UserWindow : Form
    {


        public UserWindow()
        {
            InitializeComponent();

            LoadProducts();
        }

        private void LoadProducts()
        {
            ProductListView.LargeImageList = imageList;
            using (var context = new ProductContext())
            {
                var products = context.Products.ToList();

                foreach (var product in products)
                {
                    // Загрузка изображений
                    try
                    {
                        var request = WebRequest.Create(product.Image);
                        using (var response = request.GetResponse())
                        using (var stream = response.GetResponseStream())
                        {
                            imageList.Images.Add(product.Name, Image.FromStream(stream));
                        }

                    }
                    catch (Exception ex) { MessageBox.Show("Произошла ошибка: " + ex.Message); }


                    // Создание элемента для ListView
                    var listViewItem = new ListViewItem(new[] {
                    product.Name,
                    product.Id.ToString(),
                    product.Price.ToString("C")
                    });

                    listViewItem.ImageIndex = imageList.Images.IndexOfKey(product.Name);

                    ProductListView.Items.Add(listViewItem);

                }

            }
        }

        private void ProductListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProductListView.SelectedItems.Count > 0)
            {
                var selected = ProductListView.SelectedItems[0];
            }
        }
    }
}
