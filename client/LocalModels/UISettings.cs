using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace client.LocalModels
{
    public class UISettings : INotifyPropertyChanged
    {
        private bool isViewMode = true;
        public bool IsViewMode
        {
            get { return isViewMode; }
            set
            {
                if (isViewMode != value)
                {
                    isViewMode = value;
                    OnPropertyChanged();
                }
            }
        }

        private bool isSingleOrNone = true;
        public bool IsSingleOrNone
        {
            get { return isSingleOrNone; }
            set
            {
                if (isSingleOrNone != value)
                {
                    isSingleOrNone = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string? name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
