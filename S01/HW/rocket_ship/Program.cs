using System.Runtime.InteropServices;

namespace exercise02_0;

class Program
{
    public static void make_space(int t){
        t += 1;
        while(t-- > 0){
            Console.Write(" ");
        }
        return;
    }

    public static void print_top_row(int rocket_length, int curr_length){
        make_space((rocket_length- curr_length)/2);
        if(curr_length == 1){
            Console.Write("^");
            Console.Write("\n");
        }
        else {
            for(int i = 0; i< curr_length/2; i++)
                Console.Write("/");
            Console.Write("|");
            for(int i = 0; i< curr_length/2; i++)
                Console.Write("\\");
            Console.Write("\n");
        }
        return;
    }

    public static void rocket_top(int rocket_length){
        int curr_length = 1;
        while(curr_length <= rocket_length){
            print_top_row(rocket_length,curr_length);
            curr_length += 2;
        }
        return;
    }

    public static void block_row(int rocket_length, char c){
        Console.Write("+");
        for(int i = 0; i< rocket_length; i++)
            Console.Write(c);
        Console.Write("+");
        Console.Write("\n");
        return;
    }

    public static void rocket_Block(int rocket_length , int block_cnt){
        while(block_cnt-- > 0){
            block_row(rocket_length , '-');
            for(int i =0; i< 4; i++)
                block_row(rocket_length, '*');
        }
        block_row(rocket_length , '-');
        return;
    }

    public static void make_rocket(int rocket_length, int block_cnt){
        rocket_top(rocket_length);
        rocket_Block(rocket_length,block_cnt);
        rocket_top(rocket_length);
    }

    static void Main(string[] args)
    {
        int block_cnt = 3;
        int length = 7;
        make_rocket(length, block_cnt);
        
    }
}
