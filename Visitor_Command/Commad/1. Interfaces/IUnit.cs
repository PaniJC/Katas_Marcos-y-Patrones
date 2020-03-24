using System;
using System.Collections.Generic;
using System.Text;

namespace Commad.Interfaces
{
   public interface IUnit
    {
        int Minerals { get; set; }
        Point Position { get; set; }

        void Move(int x, int y);
        void Gather();
    }
}
