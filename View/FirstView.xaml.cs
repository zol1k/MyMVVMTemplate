using System.Windows.Controls;
using MyMvvmTemplate.ViewModel;

namespace MyMvvmTemplate.View
{
    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>
    public partial class FirstView : UserControl
    {
        public FirstView()
        {
            this.DataContext = new FirstViewModel();
            InitializeComponent();
        }
    }
}

