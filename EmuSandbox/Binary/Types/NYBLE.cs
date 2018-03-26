using System;
using System.Collections.Generic;
using System.Text;

namespace EmuSandbox
{
    public static partial class Binary
    {
        public partial class NYBLE : BinaryValue
        {
            #region Properties

            private byte mnNyble;

            #endregion

            #region Constructors

            public NYBLE ( byte nNyble )
            {
                mnNyble = ( byte ) ( nNyble & BinaryValue.BitMask_4bit );
            }

            public NYBLE ( )
            {
                new NYBLE ( ( byte ) BinaryValue.Zero_4bit );
            }

            #endregion

            #region Private Methods

            private bool CheckBitBoundaries ( int iBitToSet , int iConstraint )
            {
                if ( iBitToSet < 0 || iBitToSet > iConstraint )
                {
                    throw new Exception ( "Cannot set [BIT: " + Convert.ToString ( iBitToSet , 2 ).PadLeft ( 4 , '0' ) );
                    return false;
                }

                if ( iConstraint > Math.Abs ( Binary.NYBLE.Size ) )
                {
                    throw new Exception ( "Cannot set [BIT: " + Convert.ToString ( iBitToSet , 2 ).PadLeft ( 4 , '0' ) );
                }

                return true;
            }

            #endregion

            #region Accessors

            public byte Value
            {
                get { return ( byte ) ( mnNyble & 0x0F ); }
                set { mnNyble = ( byte ) ( value & 0x0F ); }
            }

            public static new int Size
            {
                get { return 1; }
            }

            public static new int SizeInBits
            {
                get { return ConventionSupport.BitsPerNyble; }
            }

            public static byte MaxValue
            {
                get { return BinaryValue.BitMask_4bit; }
            }

            public static byte Zero
            {
                get { return BinaryValue.Zero_4bit; }
            }

            public static new Type UnderlyingType
            {
                get { return typeof ( byte ); }
            }

            #endregion

            #region In Design

            public void SetBitOn ( int iBitToSetOneToFour )
            {
                if ( iBitToSetOneToFour < 0 || iBitToSetOneToFour > 3 )
                {
                    throw new Exception ( "Cannot 'SetBitOn': [BIT: 0b" + Convert.ToString ( iBitToSetOneToFour ).PadLeft ( 4 , '0' ) + " in Binary.NYBLE: Bit must be greater than or equal 0 and less than 4" );
                }

                byte bSetBit = ( byte ) ( 1 << iBitToSetOneToFour );

                Console.WriteLine ( Convert.ToString ( bSetBit ).PadLeft ( 4 , '0' ) );

                this.Value = ( byte ) ( bSetBit | this.Value );

            }

            public void SetBitOff ( int iBitToSetOneToFour )
            {
                if ( iBitToSetOneToFour < 0 || iBitToSetOneToFour > 3 )
                {
                    throw new Exception ( "Cannot 'SetBitOn': [BIT: 0b" + Convert.ToString ( iBitToSetOneToFour ).PadLeft ( 4 , '0' ) + " in Binary.NYBLE: Bit must be greater than or equal 0 and less than 4" );
                }

                byte bSetBit = ( byte ) ( ( 0 << iBitToSetOneToFour ) & this.Value );

                Console.WriteLine ( Convert.ToString ( bSetBit ).PadLeft ( 4 , '0' ) );

                this.Value = ( byte ) ( bSetBit | this.Value );
                { };
            }

            #endregion

            #region Convinience

            public override string ToString ( )
            {
                return "[NYBLE: " + ConventionSupport.ProduceBinaryNybleString ( (byte) (mnNyble  & BinaryValue.BitMask_4bit) ) + "]";
            }

            public override string ToStringVerbose ( )
            {
                return "[NYBLE: 0x" + mnNyble.ToString ( "X1" ) + " | 0b" + Convert.ToString ( mnNyble , 2 ).PadLeft ( 4 , '0' ) + "] ";
            }

            public override string ToStringHex ( )
            {
                throw new NotImplementedException ( );
            }

            public override string ToStringBinary ( )
            {
                throw new NotImplementedException ( );
            }

            public override string ToStringDecimal ( )
            {
                throw new NotImplementedException ( );
            }

            #endregion
        }
    }
}
