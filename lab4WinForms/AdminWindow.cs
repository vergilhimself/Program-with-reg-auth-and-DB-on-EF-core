using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4WinForms
{
    public partial class AdminWindow : Form
    {
        public AdminWindow()
        {
            InitializeComponent();
            LoadProducts();
        }
        private void LoadProducts()
        {
            ProductListView.Items.Clear();
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
                    product.Price.ToString()
                    });

                    listViewItem.ImageIndex = imageList.Images.IndexOfKey(product.Name);
                    listViewItem.Tag = product.Image;
                    ProductListView.Items.Add(listViewItem);

                }

            }
        }
        private void ProductListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProductListView.SelectedItems.Count > 0)
            {
                var selected = ProductListView.SelectedItems[0];
                Nametxb.Text = selected.SubItems[0].Text;
                Pricetxb.Text = selected.SubItems[2].Text;
                Imagetbx.Text = selected.Tag as string;
            }
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (ProductListView.SelectedItems.Count > 0)
            {
                var selected = ProductListView.SelectedItems[0];
                using (var context = new ProductContext())
                {
                    Product? product = null;
                    product = context.Products.Find(Convert.ToInt32(selected.SubItems[1].Text));
                    if (product != null)
                    {
                        product.Name = Nametxb.Text;
                        product.Price = Convert.ToDecimal(Pricetxb.Text);
                        product.Image = Imagetbx.Text;
                        context.SaveChanges();
                    }
                }
                LoadProducts();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (ProductListView.SelectedItems.Count > 0)
            {
                var selected = ProductListView.SelectedItems[0];
                using (var context = new ProductContext())
                {
                    Product? product = null;
                    product = context.Products.Find(Convert.ToInt32(selected.SubItems[1].Text));
                    if (product != null)
                    {
                        context.Products.Remove(product);
                        context.SaveChanges();
                    }
                }
                LoadProducts();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            
                
                using (var context = new ProductContext())
                {
                    Product newproduct = new Product {  Name = "Новый товар", Image = "https://content.presspage.com/uploads/1369/1920_istock-1216828053-2.jpg?10000", Price= 0};
                    context.Products.Add(newproduct);
                    context.SaveChanges();
                }
                LoadProducts();
            ProductListView.Items[ProductListView.Items.Count-1].Selected = true;
            MessageBox.Show("Добавлен шаблон товара");
        }
    }
}
