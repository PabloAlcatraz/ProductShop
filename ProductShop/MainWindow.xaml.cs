using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using ProductShop.ClassHelper;
using ProductShop.Windows;

namespace ProductShop
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            GetProductList();
        }

        private void GetProductList()
        {
            LvProduct.ItemsSource = ClassHelper.EFClass.Context.Product.ToList();
        }

        private void BtnAddToCart_Click(object sender, RoutedEventArgs e)
        {
            var btnAddToCart = sender as Button;

            if (btnAddToCart == null)
                return;
            var dish = btnAddToCart.DataContext as Product;

            if (dish == null)
                return ;

            foreach (var item in AppData.products)
            {
                if (item == dish)
                {
                    item.Count++;
                    return ;
                }
            }
            AppData.products.Add(dish); 




        }

        private void BtnCart_Click(object sender, RoutedEventArgs e)
        {
            CartWindow cartWindow = new CartWindow();
            cartWindow.ShowDialog();
            
        }
    }
}

//