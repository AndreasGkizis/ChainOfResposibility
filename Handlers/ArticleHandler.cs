using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChainOfResponsibilityExample.Common;

namespace ChainOfResponsibilityExample.Handlers
{
    internal class ArticleHandler: AbstractHandler
    {
        public override object Handle(object request, int StringLength)
        {
            int Min = 2000;
            int Max = 10000;
            if (StringLength > Min && StringLength < Max)
            {
                return $"Input is an Article. " +
                    $"Length = {StringLength}";
            }
            else
            {
                return base.Handle(request, StringLength);
            }
        }
    }

}
