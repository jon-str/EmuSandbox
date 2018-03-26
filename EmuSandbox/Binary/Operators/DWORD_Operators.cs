using System;
using System.Collections.Generic;
using System.Text;

namespace EmuSandbox
{
    public static partial class Binary
    {
        public partial class DWORD : BinaryValue
        {
            #region Increment

            public static DWORD operator ++ ( DWORD dwA ) => new DWORD ( ( dwA.Value++ ) );

            #endregion

            #region Decrement

            public static DWORD operator -- ( DWORD dwA ) => new DWORD ( ( dwA.Value-- ) );

            #endregion

            #region Addition

            public static DWORD operator + ( DWORD dwA , byte bB ) => new DWORD ( ( uint ) ( ( dwA.Value + bB ) ) );
            public static DWORD operator + ( DWORD dwA , ushort usB ) => new DWORD ( ( uint ) ( ( dwA.Value + usB ) ) );
            public static DWORD operator + ( DWORD dwA , uint uiB ) => new DWORD ( ( uint ) ( ( dwA.Value + uiB ) ) );
            public static DWORD operator + ( DWORD dwA , Binary.BIT bBit ) => new DWORD ( ( uint ) ( ( dwA.Value + bBit.Value ) ) );
            public static DWORD operator + ( DWORD dwA , Binary.NYBLE nybB ) => new DWORD ( ( uint ) ( ( dwA.Value + nybB.Value ) ) );
            public static DWORD operator + ( DWORD dwA , Binary.BYTE bB ) => new DWORD ( ( uint ) ( ( dwA.Value + bB.Value ) ) );
            public static DWORD operator + ( DWORD dwA , Binary.WORD wB ) => new DWORD ( ( uint ) ( ( dwA.Value + wB.Value ) ) );
            public static DWORD operator + ( DWORD dwA , DWORD dwB ) => new DWORD ( ( uint ) ( ( dwA.Value + dwB.Value ) ) );

            #endregion

            #region Subtraction

            public static DWORD operator - ( DWORD dwA , byte bB ) => new DWORD ( ( uint ) ( ( dwA.Value - bB ) ) );
            public static DWORD operator - ( DWORD dwA , ushort usB ) => new DWORD ( ( uint ) ( ( dwA.Value - usB ) ) );
            public static DWORD operator - ( DWORD dwA , uint uiB ) => new DWORD ( ( uint ) ( ( dwA.Value - uiB ) ) );
            public static DWORD operator - ( DWORD dwA , Binary.BIT bBit ) => new DWORD ( ( uint ) ( ( dwA.Value - bBit.Value ) ) );
            public static DWORD operator - ( DWORD dwA , Binary.NYBLE nybB ) => new DWORD ( ( uint ) ( ( dwA.Value - nybB.Value ) ) );
            public static DWORD operator - ( DWORD dwA , Binary.BYTE bB ) => new DWORD ( ( uint ) ( ( dwA.Value - bB.Value ) ) );
            public static DWORD operator - ( DWORD dwA , Binary.WORD wB ) => new DWORD ( ( uint ) ( ( dwA.Value - wB.Value ) ) );
            public static DWORD operator - ( DWORD dwA , DWORD dwB ) => new DWORD ( ( uint ) ( ( dwA.Value - dwB.Value ) ) );

            #endregion

            #region Multiplication

            public static DWORD operator * ( DWORD dwA , byte bB ) => new DWORD ( ( uint ) ( ( dwA.Value * bB ) ) );
            public static DWORD operator * ( DWORD dwA , ushort usB ) => new DWORD ( ( uint ) ( ( dwA.Value * usB ) ) );
            public static DWORD operator * ( DWORD dwA , uint uiB ) => new DWORD ( ( uint ) ( ( dwA.Value * uiB ) ) );
            public static DWORD operator * ( DWORD dwA , Binary.BIT bBit ) => new DWORD ( ( uint ) ( ( dwA.Value * bBit.Value ) ) );
            public static DWORD operator * ( DWORD dwA , Binary.NYBLE nybB ) => new DWORD ( ( uint ) ( ( dwA.Value * nybB.Value ) ) );
            public static DWORD operator * ( DWORD dwA , Binary.BYTE bB ) => new DWORD ( ( uint ) ( ( dwA.Value * bB.Value ) ) );
            public static DWORD operator * ( DWORD dwA , Binary.WORD wB ) => new DWORD ( ( uint ) ( ( dwA.Value * wB.Value ) ) );
            public static DWORD operator * ( DWORD dwA , DWORD dwB ) => new DWORD ( ( uint ) ( ( dwA.Value * dwB.Value ) ) );

            #endregion

            #region Division
            public static DWORD operator / ( DWORD dwA , byte bB ) => new DWORD ( ( uint ) ( ( dwA.Value / bB ) ) );
            public static DWORD operator / ( DWORD dwA , ushort usB ) => new DWORD ( ( uint ) ( ( dwA.Value / usB ) ) );
            public static DWORD operator / ( DWORD dwA , uint uiB ) => new DWORD ( ( uint ) ( ( dwA.Value / uiB ) ) );
            public static DWORD operator / ( DWORD dwA , Binary.BIT bBit ) => new DWORD ( ( uint ) ( ( dwA.Value / bBit.Value ) ) );
            public static DWORD operator / ( DWORD dwA , Binary.NYBLE nybB ) => new DWORD ( ( uint ) ( ( dwA.Value / nybB.Value ) ) );
            public static DWORD operator / ( DWORD dwA , Binary.BYTE bB ) => new DWORD ( ( uint ) ( ( dwA.Value / bB.Value ) ) );
            public static DWORD operator / ( DWORD dwA , Binary.WORD wB ) => new DWORD ( ( uint ) ( ( dwA.Value / wB.Value ) ) );
            public static DWORD operator / ( DWORD dwA , DWORD dwB ) => new DWORD ( ( uint ) ( ( dwA.Value / dwB.Value ) ) );

            #endregion

            #region Modulo

            public static DWORD operator % ( DWORD dwA , byte bB ) => new DWORD ( ( uint ) ( ( dwA.Value % bB ) ) );
            public static DWORD operator % ( DWORD dwA , ushort usB ) => new DWORD ( ( uint ) ( ( dwA.Value % usB ) ) );
            public static DWORD operator % ( DWORD dwA , uint uiB ) => new DWORD ( ( uint ) ( ( dwA.Value % uiB ) ) );
            public static DWORD operator % ( DWORD dwA , Binary.BIT bBit ) => new DWORD ( ( uint ) ( ( dwA.Value % bBit.Value ) ) );
            public static DWORD operator % ( DWORD dwA , Binary.NYBLE nybB ) => new DWORD ( ( uint ) ( ( dwA.Value % nybB.Value ) ) );
            public static DWORD operator % ( DWORD dwA , Binary.BYTE bB ) => new DWORD ( ( uint ) ( ( dwA.Value % bB.Value ) ) );
            public static DWORD operator % ( DWORD dwA , Binary.WORD wB ) => new DWORD ( ( uint ) ( ( dwA.Value % wB.Value ) ) );
            public static DWORD operator % ( DWORD dwA , DWORD dwB ) => new DWORD ( ( uint ) ( ( dwA.Value % dwB.Value ) ) );

            #endregion

            #region Bitwise Operators

            #region AND

            public static DWORD operator & ( DWORD dwA , byte bB ) => new DWORD ( ( uint ) ( ( dwA.Value & bB ) ) );
            public static DWORD operator & ( DWORD dwA , ushort usB ) => new DWORD ( ( uint ) ( ( dwA.Value & usB ) ) );
            public static DWORD operator & ( DWORD dwA , uint uiB ) => new DWORD ( ( uint ) ( ( dwA.Value & uiB ) ) );
            public static DWORD operator & ( DWORD dwA , Binary.BIT bBit ) => new DWORD ( ( uint ) ( ( dwA.Value & bBit.Value ) ) );
            public static DWORD operator & ( DWORD dwA , Binary.NYBLE nybB ) => new DWORD ( ( uint ) ( ( dwA.Value & nybB.Value ) ) );
            public static DWORD operator & ( DWORD dwA , Binary.BYTE bB ) => new DWORD ( ( uint ) ( ( dwA.Value & bB.Value ) ) );
            public static DWORD operator & ( DWORD dwA , Binary.WORD wB ) => new DWORD ( ( uint ) ( ( dwA.Value & wB.Value ) ) );
            public static DWORD operator & ( DWORD dwA , DWORD dwB ) => new DWORD ( ( uint ) ( ( dwA.Value & dwB.Value ) ) );

            #endregion

            #region OR

            public static DWORD operator | ( DWORD dwA , byte bB ) => new DWORD ( ( uint ) ( ( dwA.Value | bB ) ) );
            public static DWORD operator | ( DWORD dwA , ushort usB ) => new DWORD ( ( uint ) ( ( dwA.Value | usB ) ) );
            public static DWORD operator | ( DWORD dwA , uint uiB ) => new DWORD ( ( uint ) ( ( dwA.Value | uiB ) ) );
            public static DWORD operator | ( DWORD dwA , Binary.BIT bBit ) => new DWORD ( ( uint ) ( ( dwA.Value | bBit.Value ) ) );
            public static DWORD operator | ( DWORD dwA , Binary.NYBLE nybB ) => new DWORD ( ( uint ) ( ( dwA.Value | nybB.Value ) ) );
            public static DWORD operator | ( DWORD dwA , Binary.BYTE bB ) => new DWORD ( ( uint ) ( ( dwA.Value | bB.Value ) ) );
            public static DWORD operator | ( DWORD dwA , Binary.WORD wB ) => new DWORD ( ( uint ) ( ( dwA.Value | wB.Value ) ) );
            public static DWORD operator | ( DWORD dwA , DWORD dwB ) => new DWORD ( ( uint ) ( ( dwA.Value | dwB.Value ) ) );

            #endregion

            #region XOR

            public static DWORD operator ^ ( DWORD dwA , byte bB ) => new DWORD ( ( uint ) ( ( dwA.Value ^ bB ) ) );
            public static DWORD operator ^ ( DWORD dwA , ushort usB ) => new DWORD ( ( uint ) ( ( dwA.Value ^ usB ) ) );
            public static DWORD operator ^ ( DWORD dwA , uint uiB ) => new DWORD ( ( uint ) ( ( dwA.Value ^ uiB ) ) );
            public static DWORD operator ^ ( DWORD dwA , Binary.BIT bBit ) => new DWORD ( ( uint ) ( ( dwA.Value ^ bBit.Value ) ) );
            public static DWORD operator ^ ( DWORD dwA , Binary.NYBLE nybB ) => new DWORD ( ( uint ) ( ( dwA.Value ^ nybB.Value ) ) );
            public static DWORD operator ^ ( DWORD dwA , Binary.BYTE bB ) => new DWORD ( ( uint ) ( ( dwA.Value ^ bB.Value ) ) );
            public static DWORD operator ^ ( DWORD dwA , Binary.WORD wB ) => new DWORD ( ( uint ) ( ( dwA.Value ^ wB.Value ) ) );
            public static DWORD operator ^ ( DWORD dwA , DWORD dwB ) => new DWORD ( ( uint ) ( ( dwA.Value ^ dwB.Value ) ) );

            #endregion

            #region COMPLEMENT

            public static DWORD operator ~ ( DWORD dwA ) => new DWORD ( ( uint ) ( ( ~dwA.Value ) ) );

            #endregion

            #region SHIFT_LEFT

            public static DWORD operator << ( DWORD dwA , int iShiftBits ) => new DWORD ( ( uint ) ( ( dwA.Value << iShiftBits ) ) );

            #endregion

            #region SHIFT_RIGHT

            public static DWORD operator >> ( DWORD dwA , int iShiftBits ) => new DWORD ( ( uint ) ( ( dwA.Value >> iShiftBits ) ) );

            #endregion

            #endregion

            #region Comparison Operators

            #region IsEqual

            public static bool operator == ( DWORD dwA , byte bB ) => ( dwA.Value == bB );
            public static bool operator == ( DWORD dwA , ushort usB ) => ( dwA.Value == usB );
            public static bool operator == ( DWORD dwA , uint uiB ) => ( dwA.Value == uiB );
            public static bool operator == ( DWORD dwA , Binary.BIT bBit ) => ( dwA.Value == bBit.Value );
            public static bool operator == ( DWORD dwA , Binary.NYBLE nybB ) => ( dwA.Value == nybB.Value );
            public static bool operator == ( DWORD dwA , Binary.BYTE bB ) => ( dwA.Value == bB.Value );
            public static bool operator == ( DWORD dwA , Binary.WORD wB ) => ( dwA.Value == wB.Value );
            public static bool operator == ( DWORD dwA , DWORD dwB ) => ( dwA.Value == dwB.Value );

            #endregion

            #region IsNotEqual

            public static bool operator != ( DWORD dwA , byte bB ) => ( dwA.Value != bB );
            public static bool operator != ( DWORD dwA , ushort usB ) => ( dwA.Value != usB );
            public static bool operator != ( DWORD dwA , uint uiB ) => ( dwA.Value != uiB );
            public static bool operator != ( DWORD dwA , Binary.BIT bBit ) => ( dwA.Value != bBit.Value );
            public static bool operator != ( DWORD dwA , Binary.NYBLE nybB ) => ( dwA.Value != nybB.Value );
            public static bool operator != ( DWORD dwA , Binary.BYTE bB ) => ( dwA.Value != bB.Value );
            public static bool operator != ( DWORD dwA , Binary.WORD wB ) => ( dwA.Value != wB.Value );
            public static bool operator != ( DWORD dwA , DWORD dwB ) => ( dwA.Value != dwB.Value );

            #endregion

            #region GreaterThan

            public static bool operator > ( DWORD dwA , byte bB ) => ( dwA.Value > bB );
            public static bool operator > ( DWORD dwA , ushort usB ) => ( dwA.Value > usB );
            public static bool operator > ( DWORD dwA , uint uiB ) => ( dwA.Value > uiB );
            public static bool operator > ( DWORD dwA , Binary.BIT bBit ) => ( dwA.Value > bBit.Value );
            public static bool operator > ( DWORD dwA , Binary.NYBLE nybB ) => ( dwA.Value > nybB.Value );
            public static bool operator > ( DWORD dwA , Binary.BYTE bB ) => ( dwA.Value > bB.Value );
            public static bool operator > ( DWORD dwA , Binary.WORD wB ) => ( dwA.Value > wB.Value );
            public static bool operator > ( DWORD dwA , DWORD dwB ) => ( dwA.Value > dwB.Value );

            #endregion

            #region LessThan

            public static bool operator < ( DWORD dwA , byte bB ) => ( dwA.Value < bB );
            public static bool operator < ( DWORD dwA , ushort usB ) => ( dwA.Value < usB );
            public static bool operator < ( DWORD dwA , uint uiB ) => ( dwA.Value < uiB );
            public static bool operator < ( DWORD dwA , Binary.BIT bBit ) => ( dwA.Value < bBit.Value );
            public static bool operator < ( DWORD dwA , Binary.NYBLE nybB ) => ( dwA.Value < nybB.Value );
            public static bool operator < ( DWORD dwA , Binary.BYTE bB ) => ( dwA.Value < bB.Value );
            public static bool operator < ( DWORD dwA , Binary.WORD wB ) => ( dwA.Value < wB.Value );
            public static bool operator < ( DWORD dwA , DWORD dwB ) => ( dwA.Value < dwB.Value );

            #endregion

            #region GreaterThanOrEqual

            public static bool operator >= ( DWORD dwA , byte bB ) => ( dwA.Value >= bB );
            public static bool operator >= ( DWORD dwA , ushort usB ) => ( dwA.Value >= usB );
            public static bool operator >= ( DWORD dwA , uint uiB ) => ( dwA.Value >= uiB );
            public static bool operator >= ( DWORD dwA , Binary.BIT bBit ) => ( dwA.Value >= bBit.Value );
            public static bool operator >= ( DWORD dwA , Binary.NYBLE nybB ) => ( dwA.Value >= nybB.Value );
            public static bool operator >= ( DWORD dwA , Binary.BYTE bB ) => ( dwA.Value >= bB.Value );
            public static bool operator >= ( DWORD dwA , Binary.WORD wB ) => ( dwA.Value >= wB.Value );
            public static bool operator >= ( DWORD dwA , DWORD dwB ) => ( dwA.Value >= dwB.Value );

            #endregion

            #region LessThanOrEqual

            public static bool operator <= ( DWORD dwA , byte bB ) => ( dwA.Value <= bB );
            public static bool operator <= ( DWORD dwA , ushort usB ) => ( dwA.Value <= usB );
            public static bool operator <= ( DWORD dwA , uint uiB ) => ( dwA.Value <= uiB );
            public static bool operator <= ( DWORD dwA , Binary.BIT bBit ) => ( dwA.Value <= bBit.Value );
            public static bool operator <= ( DWORD dwA , Binary.NYBLE nybB ) => ( dwA.Value <= nybB.Value );
            public static bool operator <= ( DWORD dwA , Binary.BYTE bB ) => ( dwA.Value <= bB.Value );
            public static bool operator <= ( DWORD dwA , Binary.WORD wB ) => ( dwA.Value <= wB.Value );
            public static bool operator <= ( DWORD dwA , DWORD dwB ) => ( dwA.Value <= dwB.Value );

            #endregion

            #endregion
        }
    }
}
