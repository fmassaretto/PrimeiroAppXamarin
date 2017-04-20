using PrimeiroAppXamarin.ViewModel;

namespace PrimeiroAppXamarin
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new PrimeiroAppXamarinViewModel();
        }
    }
}
