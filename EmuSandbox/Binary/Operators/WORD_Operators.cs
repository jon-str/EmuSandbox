using System;
using System.Collections.Generic;
using System.Text;

namespace EmuSandbox
{
    public static partial class Binary
    {
        public partial class WORD : BinaryValue
        {
            #region Increment

            public static WORD operator ++ ( WORD wA ) => new WORD ( ( wA.Value++ ) );

            #endregion

            #region Decrement

            public static WORD operator -- ( WORD wA ) => new WORD ( ( wA.Value-- ) );

            #endregion

            #region Addition

            public static WORD operator + ( WORD wA , byte bB ) => new WORD ( ( ushort ) ( ( wA.Value + bB ) ) );
            public static WORD operator + ( WORD wA , ushort usB ) => new WORD ( ( ushort ) ( ( wA.Value + usB ) ) );
            public static WORD operator + ( WORD wA , Binary.BIT bBit ) => new WORD ( ( ushort ) ( ( wA.Value + bBit.Value ) ) );
            public static WORD operator + ( WORD wA , Binary.NYBLE nybB ) => new WORD ( ( ushort ) ( ( wA.Value + nybB.Value ) ) );
            public static WORD operator + ( WORD wA , WORD wB ) => new WORD ( ( ushort ) ( ( wA.Value + wB.Value ) ) );

            #endregion

            #region Subtraction

            public static WORD operator - ( WORD wA , byte bB ) => new WORD ( ( ushort ) ( ( wA.Value - bB ) ) );
            public static WORD operator - ( WORD wA , ushort usB ) => new WORD ( ( ushort ) ( ( wA.Value - usB ) ) );
            public static WORD operator - ( WORD wA , Binary.BIT bBit ) => new WORD ( ( ushort ) ( ( wA.Value - bBit.Value ) ) );
            public static WORD operator - ( WORD wA , Binary.NYBLE nybB ) => new WORD ( ( ushort ) ( ( wA.Value - nybB.Value ) ) );
            public static WORD operator - ( WORD wA , WORD wB ) => new WORD ( ( ushort ) ( ( wA.Value - wB.Value ) ) );

            #endregion

            #region Multiplication

            public static WORD operator * ( WORD wA , byte bB ) => new WORD ( ( ushort ) ( ( wA.Value * bB ) ) );
            public static WORD operator * ( WORD wA , ushort usB ) => new WORD ( ( ushort ) ( ( wA.Value * usB ) ) );
            public static WORD operator * ( WORD wA , Binary.BIT bBit ) => new WORD ( ( ushort ) ( ( wA.Value * bBit.Value ) ) );
            public static WORD operator * ( WORD wA , Binary.NYBLE nybB ) => new WORD ( ( ushort ) ( ( wA.Value * nybB.Value ) ) );
            public static WORD operator * ( WORD wA , WORD wB ) => new WORD ( ( ushort ) ( ( wA.Value * wB.Value ) ) );

            #endregion

            #region Division

            public static WORD operator / ( WORD wA , byte bB ) => new WORD ( ( ushort ) ( ( wA.Value / bB ) ) );
            public static WORD operator / ( WORD wA , ushort usB ) => new WORD ( ( ushort ) ( ( wA.Value / usB ) ) );
            public static WORD operator / ( WORD wA , Binary.BIT bBit ) => new WORD ( ( ushort ) ( ( wA.Value / bBit.Value ) ) );
            public static WORD operator / ( WORD wA , Binary.NYBLE nybB ) => new WORD ( ( ushort ) ( ( wA.Value / nybB.Value ) ) );
            public static WORD operator / ( WORD wA , WORD wB ) => new WORD ( ( ushort ) ( ( wA.Value / wB.Value ) ) );

            #endregion

            #region Modulo

            public static WORD operator % ( WORD wA , byte bB ) => new WORD ( ( ushort ) ( ( wA.Value % bB ) ) );
            public static WORD operator % ( WORD wA , ushort usB ) => new WORD ( ( ushort ) ( ( wA.Value % usB ) ) );
            public static WORD operator % ( WORD wA , Binary.BIT bBit ) => new WORD ( ( ushort ) ( ( wA.Value % bBit.Value ) ) );
            public static WORD operator % ( WORD wA , Binary.NYBLE nybB ) => new WORD ( ( ushort ) ( ( wA.Value % nybB.Value ) ) );
            public static WORD operator % ( WORD wA , WORD wB ) => new WORD ( ( ushort ) ( ( wA.Value % wB.Value ) ) );

            #endregion

            #region Bitwise Operators

            #region AND

            public static WORD operator & ( WORD wA , byte bB ) => new WORD ( ( ushort ) ( ( wA.Value & bB ) ) );
            public static WORD operator & ( WORD wA , ushort usB ) => new WORD ( ( ushort ) ( ( wA.Value & usB ) ) );
            public static WORD operator & ( WORD wA , Binary.BIT bBit ) => new WORD ( ( ushort ) ( ( wA.Value & bBit.Value ) ) );
            public static WORD operator & ( WORD wA , Binary.NYBLE nybB ) => new WORD ( ( ushort ) ( ( wA.Value & nybB.Value ) ) );
            public static WORD operator & ( WORD wA , WORD wB ) => new WORD ( ( ushort ) ( ( wA.Value & wB.Value ) ) );

            #endregion

            #region OR

            public static WORD operator | ( WORD wA , byte bB ) => new WORD ( ( ushort ) ( ( wA.Value | bB ) ) );
            public static WORD operator | ( WORD wA , ushort usB ) => new WORD ( ( ushort ) ( ( wA.Value | usB ) ) );
            public static WORD operator | ( WORD wA , Binary.BIT bBit ) => new WORD ( ( ushort ) ( ( wA.Value | bBit.Value ) ) );
            public static WORD operator | ( WORD wA , Binary.NYBLE nybB ) => new WORD ( ( ushort ) ( ( wA.Value | nybB.Value ) ) );
            public static WORD operator | ( WORD wA , WORD wB ) => new WORD ( ( ushort ) ( ( wA.Value | wB.Value ) ) );

            #endregion

            #region XOR

            public static WORD operator ^ ( WORD wA , byte bB ) => new WORD ( ( ushort ) ( ( wA.Value ^ bB ) ) );
            public static WORD operator ^ ( WORD wA , ushort usB ) => new WORD ( ( ushort ) ( ( wA.Value ^ usB ) ) );
            public static WORD operator ^ ( WORD wA , Binary.BIT bBit ) => new WORD ( ( ushort ) ( ( wA.Value ^ bBit.Value ) ) );
            public static WORD operator ^ ( WORD wA , Binary.NYBLE nybB ) => new WORD ( ( ushort ) ( ( wA.Value ^ nybB.Value ) ) );
            public static WORD operator ^ ( WORD wA , WORD wB ) => new WORD ( ( ushort ) ( ( wA.Value ^ wB.Value ) ) );

            #endregion

            #region COMPLEMENT

            public static WORD operator ~ ( WORD wA ) => new WORD ( ( ushort ) ( ( ~wA.Value ) ) );

            #endregion

            #region SHIFT_LEFT

            public static WORD operator << ( WORD wA , int iShiftBits ) => new WORD ( ( ushort ) ( ( wA.Value << iShiftBits ) ) );

            #endregion

            #region SHIFT_RIGHT

            public static WORD operator >> ( WORD wA , int iShiftBits ) => new WORD ( ( ushort ) ( ( wA.Value >> iShiftBits ) ) );

            #endregion

            #endregion

            #region Comparison Operators

            #region IsEqual

            public static bool operator == ( WORD wA , byte bB ) => ( wA.Value == bB );
            public static bool operator == ( WORD wA , ushort usB ) => ( wA.Value == usB );
            public static bool operator == ( WORD wA , Binary.BIT bBit ) => ( wA.Value == bBit.Value );
            public static bool operator == ( WORD wA , Binary.NYBLE nybB ) => ( wA.Value == nybB.Value );
            public static bool operator == ( WORD wA , WORD wB ) => ( wA.Value == wB.Value );

            #endregion

            #region IsNotEqual

            public static bool operator != ( WORD wA , byte bB ) => ( wA.Value != bB );
            public static bool operator != ( WORD wA , ushort usB ) => ( wA.Value != usB );
            public static bool operator != ( WORD wA , Binary.BIT bBit ) => ( wA.Value != bBit.Value );
            public static bool operator != ( WORD wA , Binary.NYBLE nybB ) => ( wA.Value != nybB.Value );
            public static bool operator != ( WORD wA , WORD wB ) => ( wA.Value != wB.Value );

            #endregion

            #region GreaterThan

            public static bool operator > ( WORD wA , byte bB ) => ( wA.Value > bB );
            public static bool operator > ( WORD wA , ushort usB ) => ( wA.Value > usB );
            public static bool operator > ( WORD wA , Binary.BIT bBit ) => ( wA.Value > bBit.Value );
            public static bool operator > ( WORD wA , Binary.NYBLE nybB ) => ( wA.Value > nybB.Value );
            public static bool operator > ( WORD wA , WORD wB ) => ( wA.Value > wB.Value );

            #endregion

            #region LessThan

            public static bool operator < ( WORD wA , byte bB ) => ( wA.Value < bB );
            public static bool operator < ( WORD wA , ushort usB ) => ( wA.Value < usB );
            public static bool operator < ( WORD wA , Binary.BIT bBit ) => ( wA.Value < bBit.Value );
            public static bool operator < ( WORD wA , Binary.NYBLE nybB ) => ( wA.Value < nybB.Value );
            public static bool operator < ( WORD wA , WORD wB ) => ( wA.Value < wB.Value );

            #endregion

            #region GreaterThanOrEqual

            public static bool operator >= ( WORD wA , byte bB ) => ( wA.Value >= bB );
            public static bool operator >= ( WORD wA , ushort usB ) => ( wA.Value >= usB );
            public static bool operator >= ( WORD wA , Binary.BIT bBit ) => ( wA.Value >= bBit.Value );
            public static bool operator >= ( WORD wA , Binary.NYBLE nybB ) => ( wA.Value >= nybB.Value );
            public static bool operator >= ( WORD wA , WORD wB ) => ( wA.Value >= wB.Value );

            #endregion

            #region LessThanOrEqual

            public static bool operator <= ( WORD wA , byte bB ) => ( wA.Value <= bB );
            public static bool operator <= ( WORD wA , ushort usB ) => ( wA.Value <= usB );
            public static bool operator <= ( WORD wA , Binary.BIT bBit ) => ( wA.Value <= bBit.Value );
            public static bool operator <= ( WORD wA , Binary.NYBLE nybB ) => ( wA.Value <= nybB.Value );
            public static bool operator <= ( WORD wA , WORD wB ) => ( wA.Value <= wB.Value );

            #endregion

            #endregion
        }
    }
}
