﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Name_random_a
{
    class NewCommand:ICommand
    {
        private readonly Action<object> action;
        private readonly Predicate<object> predicate;

        public NewCommand(Action<object> action, Predicate<object> predicate=null)
        {
            this.action = action;
            this.predicate = predicate;
        }

        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        public bool CanExecute(object parameter)
        {
            return predicate == null ? true : predicate(parameter);
        }

        public void Execute(object parameter)
        {
            action(parameter);
        }
    }
}
