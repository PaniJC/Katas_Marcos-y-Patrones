using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor.Interfaces
{
   public interface Ivisitor
    {
        void VisitLight(ILightUnit unit);
        void VisitArmored(IArmoredUnit unit);
    }
}
