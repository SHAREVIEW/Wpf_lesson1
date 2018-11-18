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

        private void MoneyLogic() {
            if (InputAmount.Text == "") {
                MessageBox.Show("请输入操作金额！！");
                return;
            }
            //存款
            if (rdb_ck.IsChecked == true) {
                cnyTotalBalance.Text = (Math.Round(Decimal.Parse(cnyTotalBalance.Text.ToString()) + Decimal.Parse(InputAmount.Text.ToString()),2)).ToString();
            }
            //取款
            if (rdb_qk.IsChecked == true) {
                cnyTotalBalance.Text = (Math.Round(Decimal.Parse(cnyTotalBalance.Text.ToString()) - Decimal.Parse(InputAmount.Text.ToString()), 2)).ToString();
            }
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            MoneyLogic();
        }


        private void Rdb_qk_Checked(object sender, RoutedEventArgs e)
        {
            MoneyLogic();
        }
    }
}
