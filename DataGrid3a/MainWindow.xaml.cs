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

namespace DataGrid3a
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Produkt> ListaProduktow { get; set; }
        public ObservableCollection<string> magazyny { get; set; }
        public string sciezka = "pack://application:,,,/obrazki/";
        public MainWindow()
        {
            InitializeComponent();
            magazyny = new ObservableCollection<string>()
            { "Katowice_m1", "Gliwice_m2", "Zabrze_m3"};
            kombo.ItemsSource = magazyny;

            ListaProduktow = new ObservableCollection<Produkt>();
            ListaProduktow.Add(new Produkt("aaa", "komputer", "Katowice_m1", 20,new Uri(sciezka+"borowik.jpg")));
            ListaProduktow.Add(new Produkt("bbb", "monitor", "Gliwice_m2", 30, new Uri(sciezka + "borowik.jpg")));
            ListaProduktow.Add(new Produkt("ccc", "klawiatura", "Katowice_m1", 25, new Uri(sciezka + "borowik.jpg")));
            ListaProduktow.Add(new Produkt("ddd", "myszka", "Gliwice_m2", 245, new Uri(sciezka + "kania.jpg")));
            ListaProduktow.Add(new Produkt("ddd", "myszka", "Gliwice_m2", 245, new Uri(sciezka + "borowik.jpg")));
            ListaProduktow.Add(new Produkt("ddd", "myszka", "Gliwice_m2", 245, new Uri(sciezka + "szatan.jpg")));
            ListaProduktow.Add(new Produkt("ddd", "myszka", "Gliwice_m2", 245, new Uri(sciezka + "borowik.jpg")));
            ListaProduktow.Add(new Produkt("ddd", "myszka", "Gliwice_m2", 245, new Uri(sciezka + "kurka.jpg")));
            DataContext = this;
        }
    }
}
