using Xamarin.Forms;

namespace PrimeiroAppXamarin.ViewModel
{
    public class PrimeiroAppXamarinViewModel : BaseViewModel
    {
        private int _primeiroNumero;

        public int PrimeiroNumero
        {
            get { return _primeiroNumero; }
            set
            {
                _primeiroNumero = value;
                OnPropertyChanged();
                SomarCommand.ChangeCanExecute();
            }
        }

        private int _segundoNumero;

        public int SegundoNumero
        {
            get { return _segundoNumero; }
            set
            {
                _segundoNumero = value;
                OnPropertyChanged();
                SomarCommand.ChangeCanExecute();
            }
        }

        private int _resultado;

        public int Resultado
        {
            get { return _resultado; }
            set
            {
                _resultado = value;
                OnPropertyChanged();
            }
        }

        public Command SomarCommand { get; private set; }
        public PrimeiroAppXamarinViewModel()
        {
            SomarCommand = new Command(ExecuteSomarCommand, CanExecuteSomarCommand);
        }

        private void ExecuteSomarCommand()
        {
            Resultado = PrimeiroNumero + SegundoNumero;
        }

        private bool CanExecuteSomarCommand()
        {
            return PrimeiroNumero >= 1 && SegundoNumero >= 1;
        }
    }
}
