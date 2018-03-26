using System;
using System.Collections.Generic;
using System.Text;

namespace EmuSandbox
{
    public static partial class Binary
    {
        public partial class QWORD : BinaryValue
        {
            #region Properties

            ulong mulQWORD;

            Binary.DWORD mdwHighDWORD;
            Binary.DWORD mdwLowDWORD;

            #endregion

            #region Constructor

            public QWORD ( ulong ulQWORD )
            {
                mulQWORD = Align(ulQWORD);
            }

            public QWORD()
            {
                new QWORD ( BinaryValue.Zero_64bit);
            }

            #endregion

            #region Private Methods
            private ulong Align ( ulong ulQWORD )
            {

                mdwHighDWORD = new Binary.DWORD ( ( uint ) ( ( ulQWORD ) >> 32 ) );
                mdwLowDWORD = new Binary.DWORD ( ( uint ) ( ulQWORD ) );

                return ( ulong ) ( ( ( ( ulong ) mdwHighDWORD.Value ) << 32 ) | mdwLowDWORD.Value );
            }
            #endregion

            #region Accessors

            public ulong Value
            {
                get { return mulQWORD; }
                set
                {
                    mulQWORD = Align (value);
                }
            }

            public Binary.DWORD HighDWORD
            {
                get { return mdwHighDWORD; }
                set { mdwHighDWORD = value; }
            }

            public Binary.DWORD LowDWORD
            {
                get { return mdwLowDWORD; }
                set { mdwLowDWORD = value; }
            }
            public static new int Size
            {
                get { return sizeof ( ulong ); }
            }

            public static new int SizeInBits
            {
                get { return QWORD.Size * ConventionSupport.BitsPerByte; }
            }

            public static ulong MaxValue
            {
                get { return BinaryValue.BitMask_64bit; }
            }

            public static ulong Zero
            {
                get { return BinaryValue.Zero_64bit; }
            }

            public static new Type UnderlyingType
            {
                get { return typeof ( ulong ); }
            }

            #endregion

            #region Convinience

            public override string ToString ( )
            {
                return "[QWORD: " + ConventionSupport.ProduceHexString ( (ulong)( mulQWORD & BinaryValue.BitMask_64bit) ) + "]";
            }

            public override string ToStringVerbose ( )
            {
                return "[QWORD: " + ConventionSupport.HexPrefix + this.Value.ToString ( "X16" ) + " ," + mdwHighDWORD.ToStringVerbose ( ) + " ," + mdwLowDWORD.ToStringVerbose ( ) + "] ";
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

            public string ToStringAllBase ( )
            {
                return string.Format ( "[QWORD: (D): {0} | (H): {1} | (B): {2}" ,
                                      ConventionSupport.ProduceDecimalString ( mulQWORD ) ,
                                      ConventionSupport.ProduceHexString ( mulQWORD ) ,
                                      ConventionSupport.ProduceBinaryString ( mulQWORD ) 
                                      );
            }

            #endregion
        }
    }
}
