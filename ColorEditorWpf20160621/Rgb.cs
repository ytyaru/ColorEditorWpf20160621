using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace ColorEditorWpf20160621
{

    //public class Rgb
    //{
    //    public int R { get; set; }
    //    public int G { get; set; }
    //    public int B { get; set; }
    //}

    public class Rgb : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = (_, __) => { };

        public Rgb() : base() { }

        private int _R;
        public int R { get { return _R; } set { _R = value; NotifyPropertyChanged("R"); } }

        private int _G;
        public int G { get { return _G; } set { _G = value; NotifyPropertyChanged("G"); } }

        private int _B;
        public int B { get { return _B; } set { _B = value; NotifyPropertyChanged("B"); } }

        private void NotifyPropertyChanged(string propertyName = "")
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
