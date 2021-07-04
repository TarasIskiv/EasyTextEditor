﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EasyTextEditor.ViewModels.BaseViewModel
{
    internal abstract class ViewModel : INotifyPropertyChanged, IDisposable
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertychanged([CallerMemberName] string PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }

        protected virtual bool Set<T>(ref T field, T value, [CallerMemberName] string PropertyName = null)
        {
            if (Equals(field, value)) return false;
            field = value;
            OnPropertychanged(PropertyName);
            return true;
        }


        private bool Disposed;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposing || Disposed) return;

            Disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
        }
    }
}
