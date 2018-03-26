using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace EmuSandbox
{
    public static partial class Binary
    {
        public static void DumpBinaryTypes()
        {
            Console.WriteLine ( "Binary.NYBLE SIZE: (Bytes): " + Binary.NYBLE.Size + " | (Bits):  " + Binary.NYBLE.SizeInBits + ", TYPE: " + Binary.NYBLE.UnderlyingType.Name );
            Console.WriteLine ( "Binary.BYTE  SIZE: (Bytes): " + Binary.BYTE.Size  + " | (Bits):  " + Binary.BYTE.SizeInBits +  ", TYPE: " + Binary.BYTE.UnderlyingType.Name );
            Console.WriteLine ( "Binary.WORD  SIZE: (Bytes): " + Binary.WORD.Size  + " | (Bits): " + Binary.WORD.SizeInBits +  ", TYPE: " + Binary.WORD.UnderlyingType.Name );
            Console.WriteLine ( "Binary.DWORD SIZE: (Bytes): " + Binary.DWORD.Size + " | (Bits): " + Binary.DWORD.SizeInBits + ", TYPE: " + Binary.DWORD.UnderlyingType.Name );
            Console.WriteLine ( "Binary.QWORD SIZE: (Bytes): " + Binary.QWORD.Size + " | (Bits): " + Binary.QWORD.SizeInBits + ", TYPE: " + Binary.QWORD.UnderlyingType.Name );
        }

        public abstract class BinaryValue
        {
            #region Enums

            public enum StringMode
            {
                 HEX
                ,BINARY
                ,DECIMAL
                ,HEX_DECIMAL
                ,HEX_BINARY
                ,BINARY_DECIMAL
                ,ALL_BASE
                ,VERBOSE
                ,DEFAULT

            }

            #endregion

            #region Console Logging Methods

            public void Dump ( StringMode smeMode, string sPrependString)
            {
                string sMsg = string.Empty;

                if( ! ( string.IsNullOrEmpty( sPrependString ) ) )
                {
                    if ( ! ( sPrependString.EndsWith( ConventionSupport.Space ) ) )
                    {
                        sPrependString += ConventionSupport.Space;
                    }

                    sMsg += sPrependString;
                }

                switch ( smeMode )
                {

                    case StringMode.VERBOSE:
                        Console.WriteLine ( this.ToStringVerbose ( ) );
                        break;

                    case StringMode.DEFAULT:
                        Console.WriteLine ( this.ToString ( ) );
                        break;

                    case StringMode.HEX:
                        Console.Write ( this.ToStringHex ( ) );
                        break;

                    case StringMode.BINARY:
                        Console.WriteLine ( this.ToStringBinary ( ) );
                        break;

                    case StringMode.DECIMAL:
                        Console.WriteLine ( this.ToStringDecimal ( ) );
                        break;

                    case StringMode.ALL_BASE:
                    case StringMode.HEX_DECIMAL:
                    case StringMode.HEX_BINARY:
                    case StringMode.BINARY_DECIMAL:
                    default:
                        throw new NotImplementedException ( );
                }
            }

            public void Dump ( ) { Dump ( ConventionSupport.StringMode , null ); }
            public void Dump ( string sPrepend ) { Dump ( ConventionSupport.StringMode , sPrepend ); }
            public void Dump ( StringMode smeMode ) { Dump ( smeMode , null ); }

            #endregion

            public abstract string ToStringHex ( );
            public abstract string ToStringBinary( );
            public abstract string ToStringVerbose ( );
            public abstract string ToStringDecimal ( );

            public abstract new string ToString ( );

            #region Accessors

            #region Abstract / Unimplemented

            public static int Size { get; }
            public static int SizeInBits { get; }
            public static Type UnderlyingType { get; }

            #endregion

            #region Binary Convinience

            public static int BitsPerByte { get { return ConventionSupport.BitsPerByte; } }

            public static int BitsPerNyble { get { return ConventionSupport.BitsPerNyble; } }

            public static byte On_1bit { get { return mul1Bit_ON; } }
            public static byte Off_1bit { get { return mul1Bit_OFF; } }

            public static byte Zero_1bit { get { return mul1BitZero; } }
            public static byte Zero_4bit { get { return mul4bitZero; } }

            public static byte Zero_8bit { get { return mul8bitZero; } }

            public static ushort Zero_16bit { get { return mul16bitZero; } }

            public static uint Zero_32bit { get { return mul32bitZero; } }

            public static ulong Zero_64bit { get { return mul64bitZero; } }

            public static byte BitMask_1bit { get { return mul1BitMask; } }
            public static byte BitMask_4bit { get { return mul4bitMask; } }

            public static byte BitMask_8bit { get { return mul8bitMask; } }

            public static ushort BitMask_16bit { get { return mul16bitMask; } }

            public static uint BitMask_32bit { get { return mul32bitMask; } }

            public static ulong BitMask_64bit { get { return mul64bitMask; } }

            public static ulong BitMask_Top32Bits {  get { return mulTop32BitsMask; } }

            public static ulong BitMask_Bottom32Bits { get { return mulBottom832itsMask; } }

            public static uint BitMask_Top16Bits { get { return mulTop16BitsMask; } }

            public static uint BitMask_Bottom16Bits { get { return mulBottom16BitsMask; } }

            public static ushort BitMask_Top8Bits { get { return mulTop8BitsMask; } }

            public static ushort BitMask_Bottom8Bits { get { return mulBottom8BitsMask; } }

            public static byte BitMask_Top4Bits { get { return mulTop4BitsMask; } }

            public static byte BitMask_Bottom4Bits { get { return mulBottom4BitsMask; } }

            #endregion

            #endregion

            #region Constants

            private const byte      mul1Bit_ON          = 0b1;
            private const byte      mul1Bit_OFF         = 0b0;

            private const byte      mul1BitMask         = 0b0001;

            private const byte      mul4bitMask         = 0b1111;

            private const byte      mul8bitMask         = 0xFF;
            private const ushort    mul16bitMask        = 0xFFFF;
            private const uint      mul32bitMask        = 0xFFFF_FFFF;
            private const ulong     mul64bitMask        = 0xFFFF_FFFF_FFFF_FFFF;

            private const byte      mulTop4BitsMask     = 0b1111_0000;
            private const byte      mulBottom4BitsMask  = 0b0000_1111;

            private const ushort    mulTop8BitsMask     = 0xFF00;
            private const ushort    mulBottom8BitsMask  = 0x00FF;

            private const uint      mulTop16BitsMask    = 0xFFFF_0000;
            private const uint      mulBottom16BitsMask = 0x0000_FFFF;

            private const ulong     mulTop32BitsMask    = 0xFFFF_FFFF_0000_00F0;
            private const ulong     mulBottom832itsMask = 0x0000_0000_FFFF_FFFF;

            private const byte      mul1BitZero     = 0b0;

            private const byte      mul4bitZero     = 0b0000;

            private const byte      mul8bitZero     = 0x00;
            private const ushort    mul16bitZero    = 0x0000;
            private const uint      mul32bitZero    = 0x0000_0000;
            private const ulong     mul64bitZero    = 0x0000_0000_0000_0000;

            #endregion
        }
    }
}
