using System;

namespace EmuSandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            Binary.BIT bBit = new Binary.BIT ( 0b1 );
            Binary.NYBLE bNyl = new Binary.NYBLE ( 0xA );
            Binary.BYTE bByt = new Binary.BYTE ( 0xCD );
            Binary.WORD bWrd = new Binary.WORD ( 0xABCD );
            Binary.DWORD bDwrd = new Binary.DWORD ( 0xDEAD_BEEF );
            Binary.QWORD bQwrd = new Binary.QWORD ( 0xF0F0_ABCD_DEAD_BEEF );

            bWrd.LowByte--;

            bBit.Dump ( );
            bNyl.Dump ( );
            bByt.Dump ( );
            bWrd.Dump ( );
            bDwrd.Dump ( );
            bQwrd.Dump ( );

            Console.WriteLine(bQwrd.ToStringAllBase ( ));

            Console.ReadKey ( );
        }
    }
}
