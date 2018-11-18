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
using System.Collections.ObjectModel;

namespace Wpf_atm
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string[] accountTypeArr = new string[] { "借记卡", "贷记卡" };
            accountTypeBox.ItemsSource = accountTypeArr; //设置下拉菜单的可选项
            accountTypeBox.SelectedIndex = 0;  //默认选中第0项



        }

        private void AcceptButton_Click(object sender, RoutedEventArgs e)
        {
            //。。do somthing
            MessageBox.Show("打印凭条");
        }
    }
}
