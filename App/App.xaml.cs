namespace App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ContentPage()
            {
                Content = new Label() { Text = "Bienvenido al curso MAUI"}
            };
        }
    }
}
