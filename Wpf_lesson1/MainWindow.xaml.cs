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

namespace Wpf_lesson1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void rotatedButton_Click(object sender, RoutedEventArgs e)
        {
             
        }

        private void rotateButton_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("rotatedButton handler, bubbling up");
        }

        private void Grid_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Grid handler, bubbling up");

        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Window handler, bubbling up");
        }

        private void rotatedButton_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("rotatedButton handler, tunneing down");
        }

        private void Grid_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Grid handler, tunneing down");
           // e.Handled = true;  //停止调用路由事件

        }

        private void Windown_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Window handler, tunneing down");
        }
    }
}
//enter、tab、esc、blank、orientation key is not means input 