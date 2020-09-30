using System.Windows.Controls;
using MyMvvmTemplate.ViewModel;

namespace MyMvvmTemplate.View
{
    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>
    public partial class SecondView : UserControl
    {
        public SecondView()
        {
            this.DataContext = new FirstViewModel();
            InitializeComponent();
        }
    }
}

