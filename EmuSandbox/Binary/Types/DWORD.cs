using System;
using System.Collections.Generic;
using System.Text;

namespace EmuSandbox
{
    public static partial class Binary
    {
        public partial class DWORD : BinaryValue
        {
            #region Properties

            uint muiDWORD;

            Binary.WORD mbwHighWord;
            Binary.WORD mbwLowWord;

            #endregion

            #region Constructors

            public DWORD ( uint uiDWORD ) { muiDWORD = Align ( uiDWORD ); }

            public DWORD ( ) { new DWORD ( BinaryValue.Zero_32bit ); }

            #endregion

            #region Private Methods

            private uint Align ( uint uiDWORD )
            {
                mbwHighWord = new Binary.WORD  ( ( ushort ) ( ( uiDWORD & BinaryValue.BitMask_Top16Bits ) >> 16) );
                mbwLowWord = new Binary.WORD (  ( ushort ) ( ( uiDWORD & BinaryValue.BitMask_Bottom16Bits ) ) );


                return ( uint ) ( ( ( ( uint ) mbwHighWord.Value ) << 16 ) | mbwLowWord.Value );
            }

            #endregion

            #region Accessors

            public uint Value
            {
                get { return muiDWORD; }
                set { muiDWORD = Align ( value ); }
            }

            public Binary.WORD HighWORD
            {
                get { return mbwHighWord; }
                set { mbwHighWord = value; }
            }

            public Binary.WORD LowWORD
            {
                get { return mbwLowWord; }
                set { mbwLowWord = value; }
            }

            public static new int Size { get { return sizeof ( uint ); } }

            public static new int SizeInBits { get { return DWORD.Size * ConventionSupport.BitsPerByte; } }

            public static uint MaxValue { get { return BinaryValue.BitMask_32bit; } }

            public static uint Zero { get { return BinaryValue.Zero_32bit; } }

            public static new Type UnderlyingType { get { return typeof ( uint ); } }

            #endregion

            #region Convinience

            public override string ToString ( )
            {
                return "[DWORD: " + ConventionSupport.ProduceHexString ( ( uint ) ( muiDWORD & BinaryValue.BitMask_32bit ) ) + "]";
            }

            public override string ToStringVerbose ( )
            {
                return "[DWORD: 0x" + muiDWORD.ToString ( "X4" ) + " ," + mbwHighWord.ToStringVerbose ( ) + " ," + mbwLowWord.ToStringVerbose ( ) + "] ";
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
