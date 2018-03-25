using System;
using System.Collections.Generic;
using System.Text;

namespace EmuSandbox
{
    public static partial class Binary
    {
        public class WORD : BinaryValue
        {
            #region Properties

            ushort musWORD;

            Binary.BYTE mbHighByte;
            Binary.BYTE mbLowByte;

            #endregion

            #region Constructor

            public WORD ( ushort usWORD ) { musWORD = Align ( usWORD ); }

            public WORD ( ) { new WORD ( BinaryValue.BitMask_16bit ); }

            #endregion

            #region Private Methods

            private ushort Align ( ushort usWORD )
            {
                mbHighByte = new Binary.BYTE ( ( byte ) ( ( usWORD & BinaryValue.BitMask_Top8Bits ) >> 8 ) );
                mbLowByte = new Binary.BYTE ( ( byte ) ( usWORD & BinaryValue.BitMask_Bottom8Bits ) );

                return ( ushort ) ( ( ( ( ushort ) mbHighByte.Value ) << 8 ) | mbLowByte.Value );
            }

            #endregion

            #region Accessors

            public ushort Value
            {
                get { return musWORD; }
                set { musWORD = Align ( value ); }
            }

            public Binary.BYTE HighByte
            {
                get { return mbHighByte; }
                set { mbHighByte = value; }
            }

            public Binary.BYTE LowByte
            {
                get { return mbLowByte; }
                set { mbLowByte = value; }
            }
            public static new int Size
            {
                get { return sizeof ( ushort ); }
            }

            public static new int SizeInBits
            {
                get { return WORD.Size * ConventionSupport.BitsPerByte; }
            }

            public static ushort MaxValue
            {
                get { return BinaryValue.BitMask_16bit; }
            }

            public static ushort Zero
            {
                get { return BinaryValue.Zero_16bit; }
            }

            public static new Type UnderlyingType
            {
                get { return typeof ( ushort ); }
            }

            #endregion

            #region Convinience

            public override string ToString ( )
            {
                return "[WORD: 0x" + musWORD.ToString ( "X4" ) + ", HB: " + mbHighByte.ToString ( ) + ", LB: " + mbLowByte.ToString ( ) + "] ";
            }

            #endregion

            #region Operators
            public static WORD operator + ( WORD wA , WORD wB )
            {
                WORD wNew = new WORD ( );
                wNew.Value = ( ushort ) ( wA.Value + wB.Value );
                return wNew;
            }
            #endregion
        }
    }
}
