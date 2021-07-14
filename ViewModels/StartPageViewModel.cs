using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Navigation;

namespace EasyTextEditor.ViewModels
{
    internal class StartPageViewModel : BaseViewModel.ViewModel
    {
        #region Text Content
        private string content;
        public string Content 
        {
            get => content;
            set => Set(ref content, value); 
        }

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
        private object txtEditor;
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
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                Models.Document.FilePath = openFileDialog.FileName;
                string val = File.ReadAllText(Models.Document.FilePath);
                Content = val;
            }
            
        }

        #endregion

        #region Button Save Logic

        public ICommand SaveCommand { get; }

        private bool CanSaveCommand(Object obj) => true;

        private void OnSaveCommand(Object obj)
        {
            if(Models.Document.FilePath == null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                if (saveFileDialog.ShowDialog() == true)
                {
                    File.WriteAllText(saveFileDialog.FileName, content);
                    MessageBox.Show("Saved");
                    Models.Document.FilePath = null;
                }
            }
            else
            {
                File.WriteAllText(Models.Document.FilePath, content);
                MessageBox.Show("Saved");
                Models.Document.FilePath = null;
            }
            
        }


        #endregion

        #region Button Save As Logic

        public ICommand SaveAsCommand { get; }

        private bool CanSaveAsCommand(Object obj) => true;

        private void OnSaveAsCommand(Object obj)
        {
            Models.Document.Content = Content;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == true) {
                File.WriteAllText(saveFileDialog.FileName, content);
                MessageBox.Show("Saved");
                Models.Document.FilePath = null;
            }
        }
        

        #endregion

        #region Button Exit Logic

        public ICommand ExitCommand { get; }

        private bool CanExitCommand(Object obj) => true;

        private void OnExitCommand(Object obj)
        {
            Application.Current.Shutdown();
        }

        #endregion

        #region Text Alignment
        private string alignmentPosition = "Left";
        


        public string AlignmentPosition 
        {
            get => alignmentPosition; 
            set => Set(ref alignmentPosition, value); 
        }

        public ICommand CenterAlignCommand { get; }

        private bool CanCenterAlignCommand(Object obj) => true;

        private void OnCenterAlignCommand(Object obj)
        {
            AlignmentPosition = "Center";
            LeftAlignBack = "LightGray";
            RightAlignBack = "LightGray";
            CenterAlignBack = "Gray";
        }

        public ICommand LeftAlignCommand { get; }

        private bool CanLeftAlignCommand(Object obj) => true;

        private void OnLeftAlignCommand(Object obj)
        {
            AlignmentPosition = "Left";
            LeftAlignBack = "Gray";
            RightAlignBack = "LightGray";
            CenterAlignBack = "LightGray";
        }


        public ICommand RightAlignCommand { get; }

        private bool CanRightAlignCommand(Object obj) => true;

        private void OnRightAlignCommand(Object obj)
        {
            AlignmentPosition = "Right";
            LeftAlignBack = "LightGray";
            RightAlignBack = "Gray";
            CenterAlignBack = "LightGray";
        }

        #endregion

        #region Font Family
        private string selectedFont = "Arial";


        public string SelectedFont

        {
            get => selectedFont; 
            set => Set(ref selectedFont, value);
        }

        private string[] fontFamilies;
        public string[] FontFamilies 
        {
            get => fontFamilies;
            set => Set(ref fontFamilies, value);
        }

        #endregion

        #region Font Size

        private int selectedSize = 8;


        public int SelectedSize

        {
            get => selectedSize;
            set => Set(ref selectedSize, value);
        }

        private int[] fontSizes;
        public int[] FontSizes
        {
            get => fontSizes;
            set => Set(ref fontSizes, value);
        }
        

        #endregion

        #region Button BackGround
        private string leftAlignBack = "Gray";
        private string centerAlignBack = "LightGray";
        private string rightAlignBack = "LightGray";

        public string LeftAlignBack 
        { get => leftAlignBack; set => Set(ref leftAlignBack, value); }
        public string CenterAlignBack 
        { get => centerAlignBack; set => Set(ref centerAlignBack, value); }
        public string RightAlignBack 
        { get => rightAlignBack; set => Set(ref rightAlignBack, value); }

        #endregion
        public StartPageViewModel()
        {
            OpenFileCommand = new Infastructure.LambdaCommand(OnOpenFileCommand, CanOpenFileCommand);
            SaveCommand = new Infastructure.LambdaCommand(OnSaveCommand, CanSaveCommand);
            SaveAsCommand = new Infastructure.LambdaCommand(OnSaveAsCommand, CanSaveAsCommand);
            ExitCommand = new Infastructure.LambdaCommand(OnExitCommand, CanExitCommand);

            CenterAlignCommand = new Infastructure.LambdaCommand(OnCenterAlignCommand, CanCenterAlignCommand);
            RightAlignCommand = new Infastructure.LambdaCommand(OnRightAlignCommand, CanRightAlignCommand);
            LeftAlignCommand = new Infastructure.LambdaCommand(OnLeftAlignCommand, CanLeftAlignCommand);
            FontFamilies = new Models.AllFonts().Fonts;
            FontSizes = new Models.AllFonts().Size;
        }
    }

}
