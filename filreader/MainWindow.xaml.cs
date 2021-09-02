using System;
using System.Collections.Generic;
using System.IO;
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

namespace filreader
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public string[] lines = File.ReadAllLines("c:/easyaccess/file.txt");
        public string[] col;
        private void bt_lines_Click(object sender, RoutedEventArgs e)
        {
            lb_output.Content = "";
            foreach (string line in lines)
            {
                col = line.Split(',');
            }
            int i = 0;
            foreach (string word in col)
            {
                lb_output.Content += $"{col[i]};";
                i++;
            }
            i = 0;
        }

        private void bt_getsecond_Click(object sender, RoutedEventArgs e)
        {
            lb_output.Content = "";
            foreach (string line in lines)
            {
                col = line.Split(',');
            }
            int i = 0;
            foreach (string word in col)
            {
                if(i % 2 == 0)
                {
                i++;
                }else
                {
                lb_output.Content += $"{col[i]};";
                    i++;
                }
            }
            i = 0;
        }
    }
}
