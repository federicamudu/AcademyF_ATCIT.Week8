using AcademyF_ATCIT.Week8.FirstMiniApp.ViewModels.SignIn2;
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

namespace AcademyF_ATCIT.Week8.FirstMiniApp.Views.SignIn
{
    /// <summary>
    /// Interaction logic for SignIn2View.xaml
    /// </summary>
    public partial class SignIn2View : Window
    {
        public SignIn2View()
        {
            InitializeComponent();
            SignIn2ViewModel vm = new SignIn2ViewModel();
            this.DataContext = vm;
        }

        private void Button_ClickRegistrati(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
