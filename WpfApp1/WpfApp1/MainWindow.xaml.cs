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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Binding binding = null;
        private List<Marvel> listHero;

        public MainWindow()
        {
            InitializeComponent();
 
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            binding = new Binding();
            //element sourse
            binding.ElementName = textBox1.Name;

            //element sourse property
            binding.Path = new PropertyPath(TextBox.TextProperty);
            binding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;

            //install binding with target
            textBlock1.SetBinding(TextBox.TextProperty, binding);

            listHero = new List<Marvel>();


            listHero.AddRange(new Marvel[] {
                new Marvel{Name="Shapoval", LastName="Capitan", HumorLevel="10+"},
                new Marvel{Name="Sovgut", LastName="FastCodding", HumorLevel="10+"},
                new Marvel{Name="Nikita", LastName="Nikita", HumorLevel="10+"},
                new Marvel{Name="Shapoval", LastName="IronMan", HumorLevel="12+"},
            });

            comboBox1.ItemsSource = listHero;

        }

    }
}
