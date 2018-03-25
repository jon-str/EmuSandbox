using System;
using System.Collections.Generic;
using System.Text;

namespace EmuSandbox
{
    public static partial class Binary
    {
        public partial class NYBLE : BinaryValue
        {
            public static NYBLE operator + ( NYBLE nybA , NYBLE nybB )
            {
                NYBLE nybNew = new NYBLE ( );
                nybNew.Value = ( byte ) ( ( nybA.Value + nybB.Value ) & 0x0F );
                return nybNew;
            }

            public static NYBLE operator - ( NYBLE nybA , NYBLE nybB )
            {
                NYBLE nybNew = new NYBLE ( );
                nybNew.Value = ( byte ) ( ( nybA.Value - nybB.Value ) & 0x0F );
                return nybNew;
            }

            public static NYBLE operator * ( NYBLE nybA , NYBLE nybB )
            {
                NYBLE nybNew = new NYBLE ( );
                nybNew.Value = ( byte ) ( ( nybA.Value * nybB.Value ) & 0x0F );
                return nybNew;
            }

            public static NYBLE operator / ( NYBLE nybA , NYBLE nybB )
            {
                NYBLE nybNew = new NYBLE ( );
                nybNew.Value = ( byte ) ( ( nybA.Value / nybB.Value ) & 0x0F );
                return nybNew;
            }
        }
    }
}
