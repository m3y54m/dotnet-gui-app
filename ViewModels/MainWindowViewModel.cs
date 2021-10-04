using System;
using System.Collections.Generic;
using System.Text;
// For Reactive Commands 
using ReactiveUI;
// For 'Unit' types
using System.Reactive;

namespace dotnet_gui_app.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        // Define your ViewModels here:

        // https://stackoverflow.com/questions/5096926/what-is-the-get-set-syntax-in-c
        private string clickStatusUpdate;
        public string ClickStatusUpdate
        {
            get => clickStatusUpdate;
            set => this.RaiseAndSetIfChanged(ref clickStatusUpdate, value);
        }

        // class default constructor
        public MainWindowViewModel()
        {
            UpdateTextFromReactiveCommand = ReactiveCommand.Create(
                () => { UpdateTextStatus("Reactive Command Button"); });
        }

        public void UpdateFromSimpleMethod()
        {
            UpdateTextStatus("Simple Method Button");
        }

        public void UpdateTextStatus(string nameOfUpdater)
        {
            ClickStatusUpdate = $"{nameOfUpdater} updated me at {DateTime.Now}";
        }
        
        public ReactiveCommand<Unit, Unit> UpdateTextFromReactiveCommand { get; }
        
    }
}
