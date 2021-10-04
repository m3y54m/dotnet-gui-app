using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
// use MainWindowViewModel class
using dotnet_gui_app.ViewModels;

namespace dotnet_gui_app.Views
{
    public partial class MainWindow : Window
    {
        private MainWindowViewModel SpecificViewModel => DataContext as MainWindowViewModel;

        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
            var clickCodeButton = this.Find<Button>("ClickCodeButton");
            clickCodeButton.Click += delegate
            {
                SpecificViewModel.UpdateTextStatus("On Click Code Button");
            };
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}