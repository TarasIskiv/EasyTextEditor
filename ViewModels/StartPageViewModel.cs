using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Navigation;

namespace EasyTextEditor.ViewModels
{
    internal class StartPageViewModel : BaseViewModel.ViewModel
    {
        #region Text Block
        private string textBlockField;
        private readonly static string textBlockFieldValue = "Welcome to Text Editor";

        public string TextBlockField { get; private set; } = textBlockFieldValue;

        #endregion

        #region Button Open File
        private string buttonOpenField;
        private readonly static string buttonOpenFieldValue = "Open File";

        public string ButtonOpenField
        {
            get;
            private set;
        } = buttonOpenFieldValue;

        #endregion

        #region Button Create File
        private string buttonCreateField;
        private readonly static string buttonCreateFieldValue = "Create File";

        public string ButtonCreateField
        {
            get;
            private set;
        } = buttonCreateFieldValue;

        #endregion

        #region Button Open File Logic

        public ICommand OpenFileCommand { get; }

        private bool CanOpenFileCommand(Object obj) => true;

        private void OnOpenFileCommand(Object obj)
        {
            
        }

        #endregion


        #region Button Create File Logic

        public ICommand CreateFileCommand { get; }

        private bool CanCreateFileCommand(Object obj) => true;

        private void OnCreateFileCommand(Object obj)
        {
           
            
            
        }


        #endregion
        public StartPageViewModel()
        {
            OpenFileCommand = new Infastructure.LambdaCommand(OnOpenFileCommand, CanOpenFileCommand);
            CreateFileCommand = new Infastructure.LambdaCommand(OnCreateFileCommand, CanCreateFileCommand);
        }
    }

}
