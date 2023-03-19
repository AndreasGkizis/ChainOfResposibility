using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityExample.Handlers
{
    internal class SentenceHandler : AbstractHandler
    {
        public override object Handle(object request, int StringLength)
        {
            int Min = 20; 
            int Max = 200;
            if (StringLength > Min && StringLength < Max)
            {
                return $"Input is a Sentence. " +
                    $"Length = {StringLength}";
            }
            else
            {
                return base.Handle(request, StringLength);
            }
        }
    }
}
