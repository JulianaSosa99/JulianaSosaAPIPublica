using JulianaSosaAPIPublica.Views;

namespace JulianaSosaAPIPublica
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new JSApodPage();
        }
    }
}
