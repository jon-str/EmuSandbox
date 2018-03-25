using System;
using System.Collections.Generic;
using System.Text;

namespace EmuSandbox
{
    public static partial class Binary
    {
        public partial class BYTE : BinaryValue
        {
            public static BYTE operator + ( BYTE bA , BYTE bB ) { return new BYTE ( ( byte ) ( ( bA.Value + bB.Value ) ) ); }

            public static BYTE operator + ( BYTE bA , byte bB ) { return new BYTE ( ( byte ) ( ( bA.Value + bB ) ) ); }


            public static BYTE operator + ( BYTE bA , Binary.NYBLE nybB )
            {
                BYTE bNew = new BYTE ( );
                bNew.Value = ( byte ) ( ( bA.Value + nybB.Value ) );
                return bNew;
            }

            public static BYTE operator - ( BYTE bA , BYTE bB )
            {
                BYTE bNew = new BYTE ( );
                bNew.Value = ( byte ) ( ( bA.Value - bB.Value ) );
                return bNew;
            }
            public static BYTE operator - ( BYTE bA , byte bB )
            {
                BYTE bNew = new BYTE ( );
                bNew.Value = ( byte ) ( ( bA.Value - bB ) );
                return bNew;
            }

            public static BYTE operator * ( BYTE bA , BYTE bB )
            {
                BYTE bNew = new BYTE ( );
                bNew.Value = ( byte ) ( ( bA.Value * bB.Value ) );
                return bNew;
            }

            public static BYTE operator * ( BYTE bA , byte bB )
            {
                BYTE bNew = new BYTE ( );
                bNew.Value = ( byte ) ( ( bA.Value * bB ) );
                return bNew;
            }

            public static BYTE operator / ( BYTE bA , BYTE bB )
            {
                BYTE bNew = new BYTE ( );
                bNew.Value = ( byte ) ( ( bA.Value / bB.Value ) );
                return bNew;
            }


            public static BYTE operator / ( BYTE bA , byte bB )
            {
                BYTE bNew = new BYTE ( );
                bNew.Value = ( byte ) ( ( bA.Value / bB ) );
                return bNew;
            }
        }
    }
}
