using System;
using System.Collections.Generic;
using System.Text;

namespace EmuSandbox
{
    public static partial class Binary
    {
        public class BIT : BinaryValue
        {
            #region Properties

            private Binary.NYBLE mbnValue;

            #endregion

            #region Constructors

            public BIT ( bool bOnOrOff )
            {
                if ( bOnOrOff == true )
                {
                    mbnValue = new Binary.NYBLE ( ( byte ) ( BinaryValue.On_1bit ) );
                }
                else if ( bOnOrOff == false )
                {
                    mbnValue = new Binary.NYBLE ( ( byte ) ( BinaryValue.Off_1bit ) );
                }
                else
                {
                    throw new Exception ( "Binary.BIT must be 0b0001 or 0b0000 only!!!" );
                }
            }

            public BIT ( int iOnOrOff )
            {
                if ( iOnOrOff == 1 )
                {
                    mbnValue = new Binary.NYBLE ( ( byte ) ( BinaryValue.On_1bit ) );
                }
                else if ( iOnOrOff == 0 )
                {
                    mbnValue = new Binary.NYBLE ( ( byte ) ( BinaryValue.Off_1bit ) );
                }
                else
                {
                    throw new Exception ( "Binary.BIT must be ON (bool: true) or OFF (bool: false) only!!!" );
                }


            }

            public BIT ( )
            {
                new BIT ( BinaryValue.Zero_1bit );
            }

            #endregion

            #region Accessors

            public byte Value
            {
                get { return ( byte ) ( mbnValue.Value & 0b0001 ); }
                set { mbnValue.Value = ( byte ) ( value & 0b0001 ); }

            }

            public static new int Size
            {
                get { return 1; }
            }

            public static new int SizeInBits
            {
                get { return 1; }
            }

            public static byte MaxValue
            {
                get { return BinaryValue.BitMask_1bit; }
            }

            public static byte Zero
            {
                get { return BinaryValue.Zero_1bit; }
            }

            #endregion

            #region Convinience

            public override string ToString ( )
            {
                return "[BIT: " + ConventionSupport.ProduceBinaryString ( (byte) (mbnValue.Value & BinaryValue.BitMask_1bit) ) + "]";
            }

            public override string ToStringVerbose ( )
            {
                return "[BIT: 0b" + Convert.ToString ( ( mbnValue.Value & 0x01 ) , 2 ).PadLeft ( 1 , '0' );
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
