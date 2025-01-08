using System;
namespace ExtensionMethod
{
    public  static class StringExtensions
    {
       
        public static string AddHello(this String str)
        {
            return "Hello "+str;
        }
    }
}
