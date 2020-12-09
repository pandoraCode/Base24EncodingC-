using System;
using Base64;
namespace TestBase64lib
{
    class Program
    {
        static void Main(string[] args)
        { 
            byte[] source= { 0x6A, 0x77, 0xC4};
            Console.WriteLine(base64.Encode(source));

        }
    }
}
