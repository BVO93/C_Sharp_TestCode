using System;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace Template
{
    public abstract class Observable : INotifyPropertyChanging, INotifyPropertyChanged
    {
        public static CultureInfo CurrentCulture = new CultureInfo("en-US");

        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public void RaisePropertyChanged(string propertyName)
        {
            OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }

        protected bool Set<T>(ref T backingStore, T value, [CallerMemberName] string propertyName = null)
        {
            if (Object.Equals(backingStore, value))
                return false;

            OnPropertyChanging(new PropertyChangingEventArgs(propertyName));
            backingStore = value;
            OnPropertyChanged(new PropertyChangedEventArgs(propertyName));

            return true;
        }

        protected virtual void OnPropertyChanging(PropertyChangingEventArgs e)
        {
            PropertyChanging?.Invoke(this, e);
        }

        protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }
    }
}
