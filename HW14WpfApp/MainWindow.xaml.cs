using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace HW14WpfApp
{
    //Определить класс Product для хранения информации о товаре.
    //Класс должен содержать характеристики
    //Название товара (строка), Цена (число),
    //Изображение (строка - путь к файлу с изображением),
    //Категория (перечисление, возможные значения – Еда,
    //Бытовая техника).
    //Разработать шаблон данных для отображения списка товаров
    //в компоненте ListBox.
    //При помощи триггеров определите разный шаблон для товаров
    //категории Еда и категории Бытовая техника.
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product> ();
            products.Add(new Product()
            {
                ProdName = "Bananas",
                Price = 70,
                ProdImage = "Data/Bananas.jpg",
                ProductCategory = ProductCategorys.Food
            });
            products.Add(new Product()
            {
                ProdName = "VacuumCleaner",
                Price = 2000,
                ProdImage = "Data/Vacuumcleaner.jpg",
                ProductCategory = ProductCategorys.Appliances
            });
            products.Add(new Product()
            {
                ProdName = "Chocolate",
                Price = 40,
                ProdImage = "Data/Chocolate.jpg",
                ProductCategory = ProductCategorys.Food
            });
            products.Add(new Product()
            {
                ProdName = "TeaPot",
                Price = 1000,
                ProdImage = "Data/Teapot.jpg",
                ProductCategory = ProductCategorys.Appliances
            });
            products.Add(new Product()
            {
                ProdName = "Microwave",
                Price = 1500,
                ProdImage = "Data/Microvawe.jpg",
                ProductCategory = ProductCategorys.Appliances
            });
            listBox.ItemsSource = products;
        }
    }
}
