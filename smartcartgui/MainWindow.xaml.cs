using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Threading;

namespace smartcartgui
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        new List<Inventory_Prop> cart_inventory = new List<Inventory_Prop>();

        public MainWindow()
        {
            InitializeComponent();
            setup();
            dataGrid.ItemsSource = cart_inventory;
            MyViewModel temp = new MyViewModel();
            
        }

        public void setup()
        {
            cart_inventory.Add(new Inventory_Prop
            {
                //replace with RFID info
                name = "item 1",
                price = 10,
                quantity = 1,
                tag = "11100111",
            });

            cart_inventory.Add(new Inventory_Prop
            {
                name = "item 2",
                price = 15,
                quantity = 1,
                tag = "11100222",
            });

            cart_inventory.Add(new Inventory_Prop
            {
                name = "item 3",
                price = 12,
                quantity = 1,
                tag = "11100333",
            });

        }



        private void button_Click(object sender, RoutedEventArgs e)
        {
            int total = 0;
            foreach (var item in cart_inventory)
            {
                
                total += (item.price * item.quantity);

            }

            label.Content = total.ToString();
        }

        private void ProgressBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboBox1.SelectedItem.Equals(cb_limit))
            {
                Console.WriteLine("Set spending limit");
            }
        }



    }

    public class MyViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private DateTime _now;

        public MyViewModel()
        {
            _now = DateTime.Now;
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(500);
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        public DateTime CurrentDateTime
        {
            get { return _now; }
            private set
            {
                _now = value;
                //PropertyChanged(this, new PropertyChangedEventArgs("CurrentDateTime"));
            }
        }

        void timer_Tick(object sender, EventArgs e)
        {
            CurrentDateTime = DateTime.Now;
        }

    }

    public class Inventory_Prop : INotifyPropertyChanged
    {
        private string _name;
        private int _price;
        private int _quantity;
        private string _tag;

        public string name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged("name");
                }
            }
        }

        public int price
        {
            get { return _price; }
            set
            {
                if (_price != value)
                {
                    _price = value;
                    OnPropertyChanged("price");
                }
            }
        }

        public int quantity
        {
            get { return _quantity; }
            set
            {
                if (_quantity != value)
                {
                    _quantity = value;
                    OnPropertyChanged("quantity");
                }
            }
        }

        public string tag
        {
            get { return _tag; }
            set
            {
                if (_tag != value)
                {
                    _tag = value;
                    OnPropertyChanged("tag");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
