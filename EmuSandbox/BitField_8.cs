using System;
using System.Collections.Generic;
using System.Text;

namespace EmuSandbox
{
    public static partial class Binary
    {
        public class BitField_8 : Binary.BYTE
        {
            // masks 0x80, 0x40, 0x20, 0x10, 0x08, 0x04, 0x02, 0x01
            private Binary.BIT [ ] mbvBITS =
            {
                 new Binary.BIT(0x0)
                ,new Binary.BIT(0x0)
                ,new Binary.BIT(0x0)
                ,new Binary.BIT(0x0)
                ,new Binary.BIT(0x0)
                ,new Binary.BIT(0x0)
                ,new Binary.BIT(0x0)
                ,new Binary.BIT(0x0)
            };

            private byte mbValue;

            public BitField_8 ( byte bValue )
            {
                mbValue = bValue;

                mbvBITS [ 0 ].Value = ( byte ) ( mbValue & 0x01 );
                mbvBITS [ 1 ].Value = ( byte ) ( mbValue & 0x02 );
                mbvBITS [ 2 ].Value = ( byte ) ( mbValue & 0x04 );
                mbvBITS [ 3 ].Value = ( byte ) ( mbValue & 0x08 );
                mbvBITS [ 4 ].Value = ( byte ) ( mbValue & 0x10 );
                mbvBITS [ 5 ].Value = ( byte ) ( mbValue & 0x20 );
                mbvBITS [ 6 ].Value = ( byte ) ( mbValue & 0x40 );
                mbvBITS [ 7 ].Value = ( byte ) ( mbValue & 0x80 );
            }

            private void SetBit ( int iIndex , byte bValueZeroOrOne )
            {
                if ( iIndex > 7 )
                {
                    throw new Exception ( "Binary.BitField_8 only has Access to 8 BITS: iIndex out of range; must be between 0 and 7" );
                }
                if ( bValueZeroOrOne > 1 || bValueZeroOrOne < 0 )
                {
                    throw new Exception ( "Can only Set Binary.BIT value to '1' or '0' ..." );
                }


            }

            public override string ToString ( )
            {
                string sReturnString = string.Empty;

                sReturnString += mbvBITS [ 0 ].Value.ToString ( );
                sReturnString += mbvBITS [ 1 ].Value.ToString ( );
                sReturnString += mbvBITS [ 2 ].Value.ToString ( );
                sReturnString += mbvBITS [ 3 ].Value.ToString ( );
                sReturnString += mbvBITS [ 4 ].Value.ToString ( );
                sReturnString += mbvBITS [ 5 ].Value.ToString ( );
                sReturnString += mbvBITS [ 6 ].Value.ToString ( );
                sReturnString += mbvBITS [ 7 ].Value.ToString ( );

                return sReturnString;
            }
        }
    }
}
