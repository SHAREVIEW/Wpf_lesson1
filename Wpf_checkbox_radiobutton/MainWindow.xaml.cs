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

namespace Wpf_checkbox_radiobutton
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            /*
             * 在wpf中绑定comboBox的值，Dictionary【可运行】【后台绑定】放在public MainWindow下
             前台：
             <ComboBox Name="combobox" Width="120" Height="30"/>
            后台：
               Dictionary<int, string> mydic = new Dictionary<int, string>()
            {
                {1,"a"},
                {2,"b"},
                {3,"c"}
            };
            combobox.ItemsSource = mydic;
            combobox.SelectedValuePath = "Key";
            combobox.DisplayMemberPath = "Value";             
             */



        }



    }
}
