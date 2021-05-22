﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Carscollection.Infrast
{
    class BasaNPC : INotifyPropertyChanged

    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyOfPropertyChanged([CallerMemberName] string propertyName = " ")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }
    }
}
