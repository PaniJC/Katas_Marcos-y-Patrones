using System;
using System.Collections.Generic;
using System.Text;
using Commad.Interfaces;

namespace Commad.Concretas
{
    public class GatherCommand :ICommad
    {
        private IUnit unit;

        public GatherCommand(IUnit unit) { this.unit = unit; }
        public bool CanExecute()
        {
            return (unit != null) && (unit.Minerals == 0);
        }
        public void Execute()
        {
            if (CanExecute()) unit.Minerals += 5;
        }
    }
}
