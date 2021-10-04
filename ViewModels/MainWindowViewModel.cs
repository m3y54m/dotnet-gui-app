using System;
using System.Collections.Generic;
using System.Text;
using ReactiveUI;

namespace dotnet_gui_app.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        // Define your ViewModels here:

        // https://www.nequalsonelifestyle.com/2019/06/08/avalonia-buttons-multiple-ways/
        // https://stackoverflow.com/questions/5096926/what-is-the-get-set-syntax-in-c
        private string clickStatusUpdate; // This is the backing field
        public string ClickStatusUpdate // This is your property
        {
            get => clickStatusUpdate;
            set => this.RaiseAndSetIfChanged(ref clickStatusUpdate, value);
        }

        public void UpdateTextStatus(string nameOfUpdater)
        {
            ClickStatusUpdate = $"{nameOfUpdater} updated me at {DateTime.Now}";
        }
    }
}
