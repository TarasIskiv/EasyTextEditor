using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }

}
