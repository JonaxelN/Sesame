﻿using GalaSoft.MvvmLight;

namespace NFCRing.UI.ViewModel
{
    public abstract class ContentViewModel : ViewModelBase
    {
        private string _title;

        public string Title
        {
            get { return _title; }
            set { Set(ref _title, value); }
        }
    }
}