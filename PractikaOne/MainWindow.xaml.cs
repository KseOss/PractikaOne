using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Lib_1;

namespace PractikaOne
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void Generator_Click1(object sender, RoutedEventArgs e)
        {
            int k = 500;

            GenerationNumbers.GeneratorRandomSum(k, out string count, out int sum);
            ResultatTextBox.Text = $"Сгенерированные числа: {count}\nСумма: {sum}";
        }
    }
}