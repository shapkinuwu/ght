using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
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
using static System.Net.Mime.MediaTypeNames;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Label1.Content = "0:0";
        }
        string object1;
        Class1 Class1;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool err;
            switch(object1)
            {
                case "к":
                    к.Visibility = Visibility.Visible;
                    н.Visibility = Visibility.Hidden;
                    б.Visibility = Visibility.Hidden;
                    err =false;
                    break;
                case "н":
                    н.Visibility = Visibility.Visible;
                    к.Visibility = Visibility.Hidden;
                    б.Visibility = Visibility.Hidden;
                    err = false;
                    break;
                case "б":
                    б.Visibility = Visibility.Visible;
                    к.Visibility = Visibility.Hidden;
                    н.Visibility = Visibility.Hidden;
                    err = false;
                    break;
                    default:
                    err = true;
                    break;
            }
            if (err)
                MessageBox.Show("Ошибка");
            else
            {
                Class1= Class1.getInstance();
                switch (Class1.rnd())
                {
                    case "к":
                        к_Копировать.Visibility = Visibility.Visible;
                        н_Копировать.Visibility = Visibility.Hidden;
                        б_Копировать.Visibility = Visibility.Hidden;
                        err = false;
                        break;
                    case "н":
                        н_Копировать.Visibility = Visibility.Visible;
                        к_Копировать.Visibility = Visibility.Hidden;
                        б_Копировать.Visibility = Visibility.Hidden;
                        err = false;
                        break;
                    case "б":
                        б_Копировать.Visibility = Visibility.Visible;
                        н_Копировать.Visibility = Visibility.Hidden;
                        к_Копировать.Visibility = Visibility.Hidden;
                        err = false;
                        break;
                    default:
                        err = true;
                        break;
                }
               Label1.Content= Class1.Schet(object1);
            }
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton pressed = (RadioButton)sender;
            object1=pressed.Content.ToString();
        }
    }
}
