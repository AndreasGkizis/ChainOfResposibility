using ChainOfResponsibilityExample.Handlers;
using ChainOfResponsibilityExample.Helpers;

namespace ChainOfResponsibilityExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> ListofStringsToCheck = Example.MakeList();

            var Handler = Example.MakeChain();

            Client.ClientCode(Handler, ListofStringsToCheck);
        }
    }
}