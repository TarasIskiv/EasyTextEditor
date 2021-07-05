using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;

namespace EasyTextEditor.ViewModels
{
    internal class CreatingFilePageViewModel : BaseViewModel.ViewModel
    {

        Models.FileData data;

        private string path;
        public string Path 
        { 
            get => path;
            set => Set(ref path, value);
        }

        private string name;
        public string Name
        {
            get => name;
            set => Set(ref name, value);
        }

        public ICommand AddCommand { get; set; }

        private bool CanAddCommand(Object obj) => true;

        private void OnAddCommand(Object obj)
        {
            Models.FileData.path = Path;
            Models.FileData.fileName = Name;
            MessageBox.Show(Models.FileData.path + "\t" + Models.FileData.fileName);
            Application.Current.Shutdown();
        }

        public CreatingFilePageViewModel()
        {
            AddCommand = new Infastructure.LambdaCommand(OnAddCommand, CanAddCommand);
            
        }
    }
}
