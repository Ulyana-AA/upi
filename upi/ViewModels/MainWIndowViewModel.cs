using System;
using System.Collections.Generic;
using System.Text;

namespace upi.ViewModels
{
    internal class MainWIndowViewModel: ViewModel
    {
        public string _Title = "Ой, я кажется лопухнулся";

        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);
        }
    }
}
