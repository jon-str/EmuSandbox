using System;

namespace EmuSandbox
{
    class Program
    {
        static void Main(string[] args)
        { 
            //Binary.DumpBinaryTypes ( );

            Binary.DWORD bqWord = new Binary.DWORD ( 0xF0F0_ABCD );

            bqWord.Dump ( );

            //Binary.NYBLE bnNyb = new Binary.NYBLE ( 0b0000 );
            //bnNyb.Dump ( );

            //Console.WriteLine ( Environment.NewLine );

            //bnNyb.SetBitOn ( 0 );
            //bnNyb.Dump ( );

            //bnNyb.SetBitOn ( 1 );
            //bnNyb.Dump ( );

            //bnNyb.SetBitOn ( 2 );
            //bnNyb.Dump ( );

            //bnNyb.SetBitOn ( 3 );
            //bnNyb.Dump ( );

            //Console.WriteLine ( Environment.NewLine );

            //bnNyb.SetBitOff ( 3 );
            //bnNyb.Dump ( );

            //bnNyb.SetBitOff ( 2 );
            //bnNyb.Dump ( );

            //bnNyb.SetBitOff ( 1 );
            //bnNyb.Dump ( );

            //bnNyb.SetBitOff ( 0 );
            //bnNyb.Dump ( );



            Console.ReadKey ( );
        }
    }
}
