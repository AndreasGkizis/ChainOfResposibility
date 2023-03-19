using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityExample.Handlers
{
    internal class CharacterHandler : AbstractHandler
    {
        public override object Handle(object request, int StringLength)
        {
            int Min = 0;
            int Max = 2;

            if (StringLength > Min && StringLength < Max)
            {
                return $"Input is a Character. " +
                    $"Length = {StringLength}";
            }
            else
            {
                return base.Handle(request, StringLength);

            }
        }
    }

}
