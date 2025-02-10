using System.Net.Http.Headers;
using System.Runtime.InteropServices;

namespace Geo_ASCII_art;

class Program
{
    public static void right_tringle(int baase, char c){
        for(int i = 1; i<= baase; i++){
            for(int j = i; j<= baase; j++)
                Console.Write(" ");
            for(int j = 0; j <i;j++)
                Console.Write(c);
            Console.Write("\n");
        }
    }

    public static void left_tringle(int baase, char c){
        for(int i = 1; i<= baase; i++){
            for(int j = 1; j<=i ; j++)
                Console.Write(c);
            Console.Write("\n");
       }
    }
    static void Main(string[] args)
    {
        left_tringle(20,'8');
        right_tringle(20,'*');
    }
}
