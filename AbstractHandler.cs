using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityExample
{
    internal class AbstractHandler : IHandler
    {
        private IHandler _nextHandler;

        public IHandler SetNext(IHandler nextHandler)
        {
            // needed to chain handlers 
            this._nextHandler = nextHandler;
            return nextHandler;
        }

        /// <summary>
        /// The Handle method will be passed down to each individual handler 
        /// if there is a next inline the request will be passsed down to the next handler 
        /// ELSE null will be return showing that the request has been unhandled
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        /// 

        // this is Virtual to allow it to be overridden by children classes 
        public virtual object Handle(object request, int StringLength)
        {
            if (this._nextHandler != null)
            {
                return this._nextHandler.Handle(request, StringLength);
            }
            else
            {
                return null;
            }
        }
    }
}
