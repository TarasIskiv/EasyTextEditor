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

        #region Button Save File
        private string buttonSaveField;
        private readonly static string buttonSaveFieldValue = "Save";

        public string ButtonSaveField
        {
            get;
            private set;
        } = buttonSaveFieldValue;

        #endregion

        #region Button SaveAs File
        private string buttonSaveAsField;
        private readonly static string buttonSaveAsFieldValue = "Save As";

        public string ButtonSaveAsField
        {
            get;
            private set;
        } = buttonSaveAsFieldValue;

        #endregion

        #region Button Exit File
        private string buttonExitField;
        private readonly static string buttonExitFieldValue = "Exit";

        public string ButtonExitField
        {
            get;
            private set;
        } = buttonExitFieldValue;

        #endregion

        #region Button Open File Logic

        public ICommand OpenFileCommand { get; }

        private bool CanOpenFileCommand(Object obj) => true;

        private void OnOpenFileCommand(Object obj)
        {
            
        }

        #endregion

        #region Button Save Logic

        public ICommand SaveCommand { get; }

        private bool CanSaveCommand(Object obj) => true;

        private void OnSaveCommand(Object obj)
        {

           
           
            
        }


        #endregion

        #region Button Save As Logic

        public ICommand SaveAsCommand { get; }

        private bool CanSaveAsCommand(Object obj) => true;

        private void OnSaveAsCommand(Object obj)
        {


        }

        #endregion

        #region Button Save As Logic

        public ICommand ExitCommand { get; }

        private bool CanExitCommand(Object obj) => true;

        private void OnExitCommand(Object obj)
        {
            Application.Current.Shutdown();
        }

        #endregion
        public StartPageViewModel()
        {
            OpenFileCommand = new Infastructure.LambdaCommand(OnOpenFileCommand, CanOpenFileCommand);
            SaveCommand = new Infastructure.LambdaCommand(OnSaveCommand, CanSaveCommand);
            SaveAsCommand = new Infastructure.LambdaCommand(OnSaveAsCommand, CanSaveAsCommand);
            ExitCommand = new Infastructure.LambdaCommand(OnExitCommand, CanExitCommand);
        }
    }

}
