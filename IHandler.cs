using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityExample
{
    internal interface IHandler
    {
        // this will set the next handler within each handler class thus implementing CoR. in case it is unable to handle the request
        IHandler SetNext(IHandler handler);
        // In case the handler can handle the request this method will be used 
        object Handle(object request, int StringLength);
    }
}
