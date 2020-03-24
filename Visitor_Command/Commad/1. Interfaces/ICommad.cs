using System;
using System.Collections.Generic;
using System.Text;

namespace Commad.Interfaces
{
   public interface ICommad
    {
        void Execute();
        bool CanExecute();
    }
}
