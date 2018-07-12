using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Replace_ConsoleApp
{
    public class Token
    {
        public string TokenValue { get; set; }
        public string SampleValue { get; set; }
    }
    public class Program
    {
        public List<Token> GetTokenList()
        {
            List<Token> tokens = new List<Token>
            {
                new Token(){ TokenValue = "##Username##", SampleValue="John Doe" },
                new Token(){ TokenValue = "##UserEmail##", SampleValue="john.doe@contentder.com " },
                new Token(){ TokenValue = "##UserFirstName##", SampleValue="John" },
                new Token(){ TokenValue = "##UserLastName##", SampleValue="Doe"}
            };
            return tokens;
        }

        public string ReplaceTokenBySample(string StringValue)
        {
            List<Token> tokens = GetTokenList();
            foreach (var token in tokens)
            {
                StringValue = StringValue.Replace(token.TokenValue, token.SampleValue);
            }
            return StringValue;
        }

        public static void Main(string[] args)
        {
            Program obj = new Program();
            string StringValue = "Hello ##Username##! I have emailed you at ##UserEmail##. ##UserFirstName## ##UserLastName## how is you days going on. Have a good day ##Username##. ";
            Console.WriteLine(obj.ReplaceTokenBySample(StringValue));
            Console.ReadLine();
        }
    }
}