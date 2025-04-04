using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace _2025_03_20_Esemenyek
{

    internal class ActionCommand:ICommand
    {
        private readonly Action action;

        public ActionCommand(Action action)
        {
            this.action = action;
        }

        public event EventHandler ? CanExacuteChaged;

        public bool CanExecute(object? prarameter)
        {
            return true;
        }

        public void Execute(object? prarameter)
        {
            action();
        }
    }
}
