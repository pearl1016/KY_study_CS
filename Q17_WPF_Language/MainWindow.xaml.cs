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

namespace Q17_WPF_Language
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        CheckBox[] cbs; // CheckBox의 배열 cbs 선언

        public MainWindow() // 생성자
        {
            InitializeComponent();

            cbs = new CheckBox[] { cbC, cbCPP, cbCs, cbPy, cbJava };    // 배열 초기화
        }

        private void Vote(object sender, RoutedEventArgs e)
        {
            string str = string.Empty;

            foreach (var cb in cbs)
            {
                if (cb.IsChecked == true)
                    str += cb.Content + ", ";
            }
            MessageBox.Show(str + "selected!", "Language Preferred");
        }

        private void End(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
