
using System;
using System.Diagnostics;
using System.Text; 
namespace base64
{



    
    class Program
    {

        private static readonly char[] Base64Letters = new[]
                                        {  'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 
                                           'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'a',
                                           'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 
                                           'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '0', '1', '2',
                                           '3', '4', '5', '6', '7', '8', '9', '+', '/'
                                        };

          public static string Encode(byte[] source){
              int length = source.Length;
              string value=string.Empty;
              string  base64= string.Empty;
              string seq = string.Empty;
      
           for (int i = 0; i < length; i++)
                {
                       
                         //value = value + ToBinary(source[i]); 
                           value = value + Convert.ToString(source[i], 2).PadLeft(8,'0'); ;
                          if((i+1) % 3 == 0){
                                for(int j=0;j<value.Length;j++){
                                  
                                    seq =seq+ value[j]  ;
                                    if((j+1)%6 == 0){
                                        base64+=Base64Letters[ToDecimal(seq)] ;
                                        seq = string.Empty;
                                    }
                                }
                                
                                value = string.Empty;
                                 
 
                          }

                }

                return base64;

         
                   
           
        }


        public static int ToDecimal(string str){
         
            int sum = 0;
            for(int i=5; i>=0;i--){ 
                if(str[5-i].Equals('1')){
                        sum += (int)Math.Pow(2,i);         
                       
                }
               
            }
             return sum;

           


        }


                  static void Main(string[] args)
        {

            Stopwatch sw = new Stopwatch();
            sw.Start();  


           byte[] source = { 0x6A, 0x77, 0xC4,0x6A, 0x77, 0xC4,0x6A, 0x77, 0xC4};
          //Console.WriteLine(Encode(source));
          //Console.WriteLine(convert(source[0]));
             // Console.WriteLine( Encoding.Default.GetString(source));
           Console.WriteLine(Convert.ToBase64String(source));
            sw.Stop();
            Console.WriteLine("Time elapsed: {0}", sw.Elapsed);

           //ToBinary(0x6A);
        }
     

    }
}
