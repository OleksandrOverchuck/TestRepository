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

namespace TestApp;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private int _firstValue;
    private int _secondValue;

    
    private void CalcBtn_Click(object sender, RoutedEventArgs e)
    {
        if (int.TryParse(firstValueTXT.Text, out _firstValue) && int.TryParse(secondValueTXT.Text, out _secondValue))
        {
            int result = _firstValue + _secondValue;
            resultTXT.Text = result.ToString();
        }
        else
        {
            resultTXT.Text = "Incorrect input";
        }
    }

    private void ResetBtn_Click(object sender, RoutedEventArgs e)
    {
        firstValueTXT.Text = "";
        secondValueTXT.Text = "";
        resultTXT.Text = "";
    }
}