using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Apuntes5543Group7.Models
{
    public class Note : INotifyPropertyChanged
    {
        private string text;
        public string Text
        {
            get => text;
            set
            {
                if (text != value)
                {
                    text = value;
                    OnPropertyChanged();
                }
            }
        }

        private DateTime date;
        public DateTime Date
        {
            get => date;
            set
            {
                if (date != value)
                {
                    date = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string propertyName = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}