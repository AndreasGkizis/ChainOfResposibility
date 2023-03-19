using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChainOfResponsibilityExample.Common;

namespace ChainOfResponsibilityExample
{
    internal class Client
    {
        public static void ClientCode(AbstractHandler handler, List<string> exampleList)
        {
            foreach (var text in exampleList)
            {
                Console.WriteLine("");
                Console.WriteLine(
                    $"- - - - this is for '{text.FirstOrDefault<char>()}' - - - -"
                    );
                //Console.WriteLine("");
                int curLength = (text as string).Length;

                var result = handler.Handle(text, curLength);

                if (result != null)
                {
                    Console.WriteLine($"{result}");
                }
                else
                {
                    Console.WriteLine("!!__-- UNHANDLED --__!!");
                    Console.WriteLine("None of the handlers handled the request...!");
                }
            }
        }
    }
}
