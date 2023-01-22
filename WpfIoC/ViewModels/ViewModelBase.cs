using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfIoC.ViewModels
{
  public class ViewModelBase : INotifyPropertyChanged, IDisposable
  {
    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName]string propertyName = null)
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public virtual void Dispose() { }
  }
}
