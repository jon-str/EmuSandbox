using System;
using System.Collections.Generic;
using System.Text;

namespace EmuSandbox
{
    public static partial class Binary
    {
        public class BIT : BinaryValue
        {
            private Binary.NYBLE m_bn_Value;

            public BIT ( bool bOnOrOff )
            {
                if ( bOnOrOff == true )
                {
                    m_bn_Value = new Binary.NYBLE ( ( byte ) ( 0b1 ) );
                }
                else if ( bOnOrOff == false )
                {
                    m_bn_Value = new Binary.NYBLE ( ( byte ) ( 0b0 ) );
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
                    m_bn_Value = new Binary.NYBLE ( ( byte ) ( 0b1 ) );
                }
                else if ( iOnOrOff == 0 )
                {
                    m_bn_Value = new Binary.NYBLE ( ( byte ) ( 0b0 ) );
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

            public byte Value
            {
                get { return ( byte ) ( m_bn_Value.Value & 0b0001 ); }
                set { m_bn_Value.Value = ( byte ) ( value & 0b0001 ); }

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

            public override string ToString ( )
            {
                return "[BIT: 0b" + Convert.ToString ( ( m_bn_Value.Value & 0x01 ) , 2 ).PadLeft ( 1 , '0' );
            }
        }
    }
}
