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
using System.Windows.Shapes;

namespace filreader
{
    /// <summary>
    /// Interaction logic for editor.xaml
    /// </summary>
    public partial class editor : Window
    {
        public bool opened;
        public editor()
        {
            InitializeComponent();
            opened = true;
            StreamReader sr = new StreamReader("c:/easyaccess/file.txt");
            tb_file.Text = sr.ReadToEnd();
            sr.Close();
        }

        private void wd_edit_Closed(object sender, EventArgs e)
        {
            opened = false;
        }

        private void bt_safe_Click(object sender, RoutedEventArgs e)
        {
            StreamWriter sr = new StreamWriter("c:/easyaccess/file.txt");
            sr.Write(tb_file.Text);
            sr.Close();
        }
    }
}
