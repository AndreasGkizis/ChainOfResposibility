using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityExample.Handlers
{
    internal class WordHandler : AbstractHandler
    {
        public override object Handle(object request, int StringLength)
        {
            int Min = 2;
            int Max = 20;
            if (StringLength > Min && StringLength < Max)
            {
                return $"Input is a word. " +
                    $"Length = {StringLength}";
            }
            else
            {
                return base.Handle(request, StringLength);
            }
        }
    }
}
