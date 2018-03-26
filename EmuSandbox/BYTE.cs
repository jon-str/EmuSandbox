using System;
using System.Collections.Generic;
using System.Text;

namespace EmuSandbox
{
    public static partial class Binary
    {
        public partial class BYTE : BinaryValue
        {
            #region Properties

            byte mbByte;

            Binary.NYBLE mnHighNyble;
            Binary.NYBLE mnLowNyble;

            #endregion

            #region Constructors

            public BYTE ( byte bByte ) { mbByte = Align ( bByte ); }

            public BYTE ( ) { new BYTE ( BinaryValue.Zero_8bit ); }

            #endregion

            #region Private Methods

            private byte Align ( byte bByte )
            {
                mnHighNyble = new Binary.NYBLE ( ( byte ) ( ( bByte & BinaryValue.BitMask_Top4Bits ) >> 4 ) );
                mnLowNyble = new Binary.NYBLE ( ( byte ) ( bByte & BinaryValue.BitMask_Bottom4Bits ) );

                return ( byte ) ( ( ( ( byte ) mnHighNyble.Value ) << 4 ) | mnLowNyble.Value );
            }

            #endregion

            #region Accessors

            public byte Value
            {
                get { return mbByte; }
                set { mbByte = Align ( value ); }
            }

            public Binary.NYBLE HighNyble
            {
                get { return mnHighNyble; }
                set { mnHighNyble = value; }
            }

            public Binary.NYBLE LowNyble
            {
                get { return mnLowNyble; }
                set { mnLowNyble = value; }
            }

            public static new int Size
            {
                get { return sizeof ( byte ); }
            }

            public static new int SizeInBits
            {
                get { return BYTE.Size * ConventionSupport.BitsPerByte; }
            }

            public static byte MaxValue
            {
                get { return BinaryValue.BitMask_8bit; }
            }

            public static byte Zero
            {
                get { return BinaryValue.Zero_8bit; }
            }

            public static new Type UnderlyingType
            {
                get { return typeof ( byte ); }
            }

            #endregion

            #region Convinience

            public override string ToString ( )
            {
                return "[BYTE: " + ConventionSupport.ProduceHexString ( ( byte ) ( mbByte & BinaryValue.BitMask_8bit ) ) + "]";
            }

            public override string ToStringVerbose ( )
            {
                return "[BYTE: " + ConventionSupport.HexPrefix + mbByte.ToString ( "X2" ) + ", HN: " + mnHighNyble.ToStringVerbose ( ) + ", LN: " + mnLowNyble.ToStringVerbose ( ) + "] ";
            }

            public override string ToStringHex ( )
            {
                return ToString ( );
            }

            public override string ToStringBinary ( )
            {
                return "[BYTE: " + ConventionSupport.ProduceBinaryByteString ( ( byte ) ( mbByte & BinaryValue.BitMask_8bit ) ) + "]";
            }

            public override string ToStringDecimal ( )
            {
                return "[BYTE: " + ConventionSupport.ProduceDecimalString ( mbByte ) + "]";
            }

            #endregion
        }
    }
}
