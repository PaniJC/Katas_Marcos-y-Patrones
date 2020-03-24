using System;
using System.Collections.Generic;
using System.Text;
using Commad.Interfaces;

namespace Commad.Concretas
{
   public  class MoveCommand : ICommad
    {
        private IUnit unit;
        private int x;
        private int y;

        public MoveCommand(IUnit unit, int x, int y)
        {
            this.unit = unit;
            this.x = x;
            this.y = y;
        }
        public bool CanExecute() { return true; }
        public void Execute()
        {
            if (CanExecute())
            {
                unit.Position.X += x;
                unit.Position.Y += y;
            }
        }
    }
}
