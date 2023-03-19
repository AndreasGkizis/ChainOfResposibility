using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityExample.Handlers
{
    internal class ParagraphHandler : AbstractHandler
    {
        public override object Handle(object request, int StringLength)
        {
            int Min = 200;
            int Max = 2000;
            if (StringLength > Min && StringLength < Max)
            {
                return $"Input is a Paragragh. " +
                    $"Length = {StringLength}";
            }
            else
            {
                return base.Handle(request, StringLength);
            }
        }
    }
}
