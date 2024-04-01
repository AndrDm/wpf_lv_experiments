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

namespace WpfControlLibrary
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {

        /*
        public int MyColor
        {
            get { return (int)GetValue(MyColorProperty); }
            set { SetValue(MyColorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyColor.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MyColorProperty =
            DependencyProperty.Register("MyColor", typeof(int), typeof(Color), new PropertyMetadata(Color.FromRgb(255,0,0)));
        
        */
        public UserControl1()
        {
            InitializeComponent();
        }
    }
}
