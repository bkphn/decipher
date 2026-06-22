namespace Decipher
{
    using Decipher.Models;
    using Decipher.Presenter;
    using Decipher.View;
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var repository = new Repository();
            var mainView = new MainView();
            var mainPresenter = new MainPresenter(mainView, repository);

            Application.Run(mainView);
        }
    }
}