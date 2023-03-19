using ChainOfResponsibilityExample.Common;
using ChainOfResponsibilityExample.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityExample.Helpers
{
    public class Example
    {
        /// <summary>
        /// Creates an example list of strings to be checked by the chain of responsibility
        /// </summary>
        /// <returns></returns>
        internal static List<string> MakeList()
        {
            List<string> List = new List<string>();
            List.Add(new string('a', 1));
            List.Add(new string('b', 15));
            List.Add(new string('c', 150));
            List.Add(new string('d', 1500));
            List.Add(new string('e', 15000));
            List.Add(new string(string.Empty));

            return List;
        }

        /// <summary>
        /// Creates a chain which will be followed during excecution
        /// </summary>
        /// <returns></returns>
        internal static AbstractHandler MakeChain()
        {

            var CharHandler = new CharacterHandler();
            var WordHandler = new WordHandler();
            var SentenceHandler = new SentenceHandler();
            var ParagraphHandler = new ParagraphHandler();
            var ArticleHandler = new ArticleHandler();

            CharHandler.SetNext(WordHandler)
             .SetNext(SentenceHandler)
             .SetNext(SentenceHandler)
             .SetNext(ParagraphHandler)
             .SetNext(ArticleHandler);

            return CharHandler;
        }
    }
}
