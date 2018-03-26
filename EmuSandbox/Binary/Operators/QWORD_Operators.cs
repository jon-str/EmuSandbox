using System;
using System.Collections.Generic;
using System.Text;

namespace EmuSandbox
{
    public static partial class Binary
    {
        public partial class QWORD : BinaryValue
        {
            #region Increment

            public static QWORD operator ++ ( QWORD qwA ) => new QWORD ( ( qwA.Value++ ) );

            #endregion

            #region Decrement

            public static QWORD operator -- ( QWORD qwA ) => new QWORD ( ( qwA.Value-- ) );

            #endregion

            #region Addition

            public static QWORD operator + ( QWORD qwA , byte bB ) => new QWORD ( ( ulong ) ( ( qwA.Value + bB ) ) );
            public static QWORD operator + ( QWORD qwA , ushort usB ) => new QWORD ( ( ulong ) ( ( qwA.Value + usB ) ) );
            public static QWORD operator + ( QWORD qwA , uint uiB ) => new QWORD ( ( ulong ) ( ( qwA.Value + uiB ) ) );
            public static QWORD operator + ( QWORD qwA , Binary.BIT bBit ) => new QWORD ( ( ulong ) ( ( qwA.Value + bBit.Value ) ) );
            public static QWORD operator + ( QWORD qwA , Binary.NYBLE nybB ) => new QWORD ( ( ulong ) ( ( qwA.Value + nybB.Value ) ) );
            public static QWORD operator + ( QWORD qwA , Binary.BYTE bB ) => new QWORD ( ( ulong ) ( ( qwA.Value + bB.Value ) ) );
            public static QWORD operator + ( QWORD qwA , Binary.WORD wB ) => new QWORD ( ( ulong ) ( ( qwA.Value + wB.Value ) ) );
            public static QWORD operator + ( QWORD qwA , Binary.DWORD dwB ) => new QWORD ( ( ulong ) ( ( qwA.Value + dwB.Value ) ) );
            public static QWORD operator + ( QWORD qwA , QWORD qwB ) => new QWORD ( ( ulong ) ( ( qwA.Value + qwB.Value ) ) );

            #endregion

            #region Subtraction

            public static QWORD operator - ( QWORD qwA , byte bB ) => new QWORD ( ( ulong ) ( ( qwA.Value - bB ) ) );
            public static QWORD operator - ( QWORD qwA , ushort usB ) => new QWORD ( ( ulong ) ( ( qwA.Value - usB ) ) );
            public static QWORD operator - ( QWORD qwA , uint uiB ) => new QWORD ( ( ulong ) ( ( qwA.Value - uiB ) ) );
            public static QWORD operator - ( QWORD qwA , Binary.BIT bBit ) => new QWORD ( ( ulong ) ( ( qwA.Value - bBit.Value ) ) );
            public static QWORD operator - ( QWORD qwA , Binary.NYBLE nybB ) => new QWORD ( ( ulong ) ( ( qwA.Value - nybB.Value ) ) );
            public static QWORD operator - ( QWORD qwA , Binary.BYTE bB ) => new QWORD ( ( ulong ) ( ( qwA.Value - bB.Value ) ) );
            public static QWORD operator - ( QWORD qwA , Binary.WORD wB ) => new QWORD ( ( ulong ) ( ( qwA.Value - wB.Value ) ) );
            public static QWORD operator - ( QWORD qwA , Binary.DWORD dwB ) => new QWORD ( ( ulong ) ( ( qwA.Value - dwB.Value ) ) );
            public static QWORD operator - ( QWORD qwA , QWORD qwB ) => new QWORD ( ( ulong ) ( ( qwA.Value - qwB.Value ) ) );

            #endregion

            #region Multiplication

            public static QWORD operator * ( QWORD qwA , byte bB ) => new QWORD ( ( ulong ) ( ( qwA.Value * bB ) ) );
            public static QWORD operator * ( QWORD qwA , ushort usB ) => new QWORD ( ( ulong ) ( ( qwA.Value * usB ) ) );
            public static QWORD operator * ( QWORD qwA , uint uiB ) => new QWORD ( ( ulong ) ( ( qwA.Value * uiB ) ) );
            public static QWORD operator * ( QWORD qwA , Binary.BIT bBit ) => new QWORD ( ( ulong ) ( ( qwA.Value * bBit.Value ) ) );
            public static QWORD operator * ( QWORD qwA , Binary.NYBLE nybB ) => new QWORD ( ( ulong ) ( ( qwA.Value * nybB.Value ) ) );
            public static QWORD operator * ( QWORD qwA , Binary.BYTE bB ) => new QWORD ( ( ulong ) ( ( qwA.Value * bB.Value ) ) );
            public static QWORD operator * ( QWORD qwA , Binary.WORD wB ) => new QWORD ( ( ulong ) ( ( qwA.Value * wB.Value ) ) );
            public static QWORD operator * ( QWORD qwA , Binary.DWORD dwB ) => new QWORD ( ( ulong ) ( ( qwA.Value * dwB.Value ) ) );
            public static QWORD operator * ( QWORD qwA , QWORD qwB ) => new QWORD ( ( ulong ) ( ( qwA.Value * qwB.Value ) ) );

            #endregion

            #region Division
            public static QWORD operator / ( QWORD qwA , byte bB ) => new QWORD ( ( ulong ) ( ( qwA.Value / bB ) ) );
            public static QWORD operator / ( QWORD qwA , ushort usB ) => new QWORD ( ( ulong ) ( ( qwA.Value / usB ) ) );
            public static QWORD operator / ( QWORD qwA , uint uiB ) => new QWORD ( ( ulong ) ( ( qwA.Value / uiB ) ) );
            public static QWORD operator / ( QWORD qwA , Binary.BIT bBit ) => new QWORD ( ( ulong ) ( ( qwA.Value / bBit.Value ) ) );
            public static QWORD operator / ( QWORD qwA , Binary.NYBLE nybB ) => new QWORD ( ( ulong ) ( ( qwA.Value / nybB.Value ) ) );
            public static QWORD operator / ( QWORD qwA , Binary.BYTE bB ) => new QWORD ( ( ulong ) ( ( qwA.Value / bB.Value ) ) );
            public static QWORD operator / ( QWORD qwA , Binary.WORD wB ) => new QWORD ( ( ulong ) ( ( qwA.Value / wB.Value ) ) );
            public static QWORD operator / ( QWORD qwA , Binary.DWORD dwB ) => new QWORD ( ( ulong ) ( ( qwA.Value / dwB.Value ) ) );
            public static QWORD operator / ( QWORD qwA , QWORD qwB ) => new QWORD ( ( ulong ) ( ( qwA.Value / qwB.Value ) ) );


            #endregion

            #region Modulo

            public static QWORD operator % ( QWORD qwA , byte bB ) => new QWORD ( ( ulong ) ( ( qwA.Value % bB ) ) );
            public static QWORD operator % ( QWORD qwA , ushort usB ) => new QWORD ( ( ulong ) ( ( qwA.Value % usB ) ) );
            public static QWORD operator % ( QWORD qwA , uint uiB ) => new QWORD ( ( ulong ) ( ( qwA.Value % uiB ) ) );
            public static QWORD operator % ( QWORD qwA , Binary.BIT bBit ) => new QWORD ( ( ulong ) ( ( qwA.Value % bBit.Value ) ) );
            public static QWORD operator % ( QWORD qwA , Binary.NYBLE nybB ) => new QWORD ( ( ulong ) ( ( qwA.Value % nybB.Value ) ) );
            public static QWORD operator % ( QWORD qwA , Binary.BYTE bB ) => new QWORD ( ( ulong ) ( ( qwA.Value % bB.Value ) ) );
            public static QWORD operator % ( QWORD qwA , Binary.WORD wB ) => new QWORD ( ( ulong ) ( ( qwA.Value % wB.Value ) ) );
            public static QWORD operator % ( QWORD qwA , Binary.DWORD dwB ) => new QWORD ( ( ulong ) ( ( qwA.Value % dwB.Value ) ) );
            public static QWORD operator % ( QWORD qwA , QWORD qwB ) => new QWORD ( ( ulong ) ( ( qwA.Value % qwB.Value ) ) );

            #endregion

            #region Bitwise Operators

            #region AND

            public static QWORD operator & ( QWORD qwA , byte bB ) => new QWORD ( ( ulong ) ( ( qwA.Value & bB ) ) );
            public static QWORD operator & ( QWORD qwA , ushort usB ) => new QWORD ( ( ulong ) ( ( qwA.Value & usB ) ) );
            public static QWORD operator & ( QWORD qwA , uint uiB ) => new QWORD ( ( ulong ) ( ( qwA.Value & uiB ) ) );
            public static QWORD operator & ( QWORD qwA , Binary.BIT bBit ) => new QWORD ( ( ulong ) ( ( qwA.Value & bBit.Value ) ) );
            public static QWORD operator & ( QWORD qwA , Binary.NYBLE nybB ) => new QWORD ( ( ulong ) ( ( qwA.Value & nybB.Value ) ) );
            public static QWORD operator & ( QWORD qwA , Binary.BYTE bB ) => new QWORD ( ( ulong ) ( ( qwA.Value & bB.Value ) ) );
            public static QWORD operator & ( QWORD qwA , Binary.WORD wB ) => new QWORD ( ( ulong ) ( ( qwA.Value & wB.Value ) ) );
            public static QWORD operator & ( QWORD qwA , Binary.DWORD dwB ) => new QWORD ( ( ulong ) ( ( qwA.Value & dwB.Value ) ) );
            public static QWORD operator & ( QWORD qwA , QWORD qwB ) => new QWORD ( ( ulong ) ( ( qwA.Value & qwB.Value ) ) );

            #endregion

            #region OR

            public static QWORD operator | ( QWORD qwA , byte bB ) => new QWORD ( ( ulong ) ( ( qwA.Value | bB ) ) );
            public static QWORD operator | ( QWORD qwA , ushort usB ) => new QWORD ( ( ulong ) ( ( qwA.Value | usB ) ) );
            public static QWORD operator | ( QWORD qwA , uint uiB ) => new QWORD ( ( ulong ) ( ( qwA.Value | uiB ) ) );
            public static QWORD operator | ( QWORD qwA , Binary.BIT bBit ) => new QWORD ( ( ulong ) ( ( qwA.Value | bBit.Value ) ) );
            public static QWORD operator | ( QWORD qwA , Binary.NYBLE nybB ) => new QWORD ( ( ulong ) ( ( qwA.Value | nybB.Value ) ) );
            public static QWORD operator | ( QWORD qwA , Binary.BYTE bB ) => new QWORD ( ( ulong ) ( ( qwA.Value | bB.Value ) ) );
            public static QWORD operator | ( QWORD qwA , Binary.WORD wB ) => new QWORD ( ( ulong ) ( ( qwA.Value | wB.Value ) ) );
            public static QWORD operator | ( QWORD qwA , Binary.DWORD dwB ) => new QWORD ( ( ulong ) ( ( qwA.Value | dwB.Value ) ) );
            public static QWORD operator | ( QWORD qwA , QWORD qwB ) => new QWORD ( ( ulong ) ( ( qwA.Value | qwB.Value ) ) );

            #endregion

            #region XOR

            public static QWORD operator ^ ( QWORD qwA , byte bB ) => new QWORD ( ( ulong ) ( ( qwA.Value ^ bB ) ) );
            public static QWORD operator ^ ( QWORD qwA , ushort usB ) => new QWORD ( ( ulong ) ( ( qwA.Value ^ usB ) ) );
            public static QWORD operator ^ ( QWORD qwA , uint uiB ) => new QWORD ( ( ulong ) ( ( qwA.Value ^ uiB ) ) );
            public static QWORD operator ^ ( QWORD qwA , Binary.BIT bBit ) => new QWORD ( ( ulong ) ( ( qwA.Value ^ bBit.Value ) ) );
            public static QWORD operator ^ ( QWORD qwA , Binary.NYBLE nybB ) => new QWORD ( ( ulong ) ( ( qwA.Value ^ nybB.Value ) ) );
            public static QWORD operator ^ ( QWORD qwA , Binary.BYTE bB ) => new QWORD ( ( ulong ) ( ( qwA.Value ^ bB.Value ) ) );
            public static QWORD operator ^ ( QWORD qwA , Binary.WORD wB ) => new QWORD ( ( ulong ) ( ( qwA.Value ^ wB.Value ) ) );
            public static QWORD operator ^ ( QWORD qwA , Binary.DWORD dwB ) => new QWORD ( ( ulong ) ( ( qwA.Value ^ dwB.Value ) ) );
            public static QWORD operator ^ ( QWORD qwA , QWORD qwB ) => new QWORD ( ( ulong ) ( ( qwA.Value ^ qwB.Value ) ) );

            #endregion

            #region COMPLEMENT

            public static QWORD operator ~ ( QWORD qwA ) => new QWORD ( ( ulong ) ( ( ~qwA.Value ) ) );

            #endregion

            #region SHIFT_LEFT

            public static QWORD operator << ( QWORD qwA , int iShiftBits ) => new QWORD ( ( ulong ) ( ( qwA.Value << iShiftBits ) ) );

            #endregion

            #region SHIFT_RIGHT

            public static QWORD operator >> ( QWORD qwA , int iShiftBits ) => new QWORD ( ( ulong ) ( ( qwA.Value >> iShiftBits ) ) );

            #endregion

            #endregion

            #region Comparison Operators

            #region IsEqual

            public static bool operator == ( QWORD qwA , byte bB ) => ( qwA.Value == bB );
            public static bool operator == ( QWORD qwA , ushort usB ) => ( qwA.Value == usB );
            public static bool operator == ( QWORD qwA , uint uiB ) => ( qwA.Value == uiB );
            public static bool operator == ( QWORD qwA , Binary.BIT bBit ) => ( qwA.Value == bBit.Value );
            public static bool operator == ( QWORD qwA , Binary.NYBLE nybB ) => ( qwA.Value == nybB.Value );
            public static bool operator == ( QWORD qwA , Binary.BYTE bB ) => ( qwA.Value == bB.Value );
            public static bool operator == ( QWORD qwA , Binary.WORD wB ) => ( qwA.Value == wB.Value );
            public static bool operator == ( QWORD qwA , Binary.DWORD dwB ) => ( qwA.Value == dwB.Value );
            public static bool operator == ( QWORD qwA , QWORD qwB ) => ( qwA.Value == qwB.Value );

            #endregion

            #region IsNotEqual

            public static bool operator != ( QWORD qwA , byte bB ) => ( qwA.Value != bB );
            public static bool operator != ( QWORD qwA , ushort usB ) => ( qwA.Value != usB );
            public static bool operator != ( QWORD qwA , uint uiB ) => ( qwA.Value != uiB );
            public static bool operator != ( QWORD qwA , Binary.BIT bBit ) => ( qwA.Value != bBit.Value );
            public static bool operator != ( QWORD qwA , Binary.NYBLE nybB ) => ( qwA.Value != nybB.Value );
            public static bool operator != ( QWORD qwA , Binary.BYTE bB ) => ( qwA.Value != bB.Value );
            public static bool operator != ( QWORD qwA , Binary.WORD wB ) => ( qwA.Value != wB.Value );
            public static bool operator != ( QWORD qwA , Binary.DWORD dwB ) => ( qwA.Value != dwB.Value );
            public static bool operator != ( QWORD qwA , QWORD qwB ) => ( qwA.Value != qwB.Value );

            #endregion

            #region GreaterThan

            public static bool operator > ( QWORD qwA , byte bB ) => ( qwA.Value > bB );
            public static bool operator > ( QWORD qwA , ushort usB ) => ( qwA.Value > usB );
            public static bool operator > ( QWORD qwA , uint uiB ) => ( qwA.Value > uiB );
            public static bool operator > ( QWORD qwA , Binary.BIT bBit ) => ( qwA.Value > bBit.Value );
            public static bool operator > ( QWORD qwA , Binary.NYBLE nybB ) => ( qwA.Value > nybB.Value );
            public static bool operator > ( QWORD qwA , Binary.BYTE bB ) => ( qwA.Value > bB.Value );
            public static bool operator > ( QWORD qwA , Binary.WORD wB ) => ( qwA.Value > wB.Value );
            public static bool operator > ( QWORD qwA , Binary.DWORD dwB ) => ( qwA.Value > dwB.Value );
            public static bool operator > ( QWORD qwA , QWORD qwB ) => ( qwA.Value > qwB.Value );

            #endregion

            #region LessThan

            public static bool operator < ( QWORD qwA , byte bB ) => ( qwA.Value < bB );
            public static bool operator < ( QWORD qwA , ushort usB ) => ( qwA.Value < usB );
            public static bool operator < ( QWORD qwA , uint uiB ) => ( qwA.Value < uiB );
            public static bool operator < ( QWORD qwA , Binary.BIT bBit ) => ( qwA.Value < bBit.Value );
            public static bool operator < ( QWORD qwA , Binary.NYBLE nybB ) => ( qwA.Value < nybB.Value );
            public static bool operator < ( QWORD qwA , Binary.BYTE bB ) => ( qwA.Value < bB.Value );
            public static bool operator < ( QWORD qwA , Binary.WORD wB ) => ( qwA.Value < wB.Value );
            public static bool operator < ( QWORD qwA , Binary.DWORD dwB ) => ( qwA.Value < dwB.Value );
            public static bool operator < ( QWORD qwA , QWORD qwB ) => ( qwA.Value < qwB.Value );

            #endregion

            #region GreaterThanOrEqual

            public static bool operator >= ( QWORD qwA , byte bB ) => ( qwA.Value >= bB );
            public static bool operator >= ( QWORD qwA , ushort usB ) => ( qwA.Value >= usB );
            public static bool operator >= ( QWORD qwA , uint uiB ) => ( qwA.Value >= uiB );
            public static bool operator >= ( QWORD qwA , Binary.BIT bBit ) => ( qwA.Value >= bBit.Value );
            public static bool operator >= ( QWORD qwA , Binary.NYBLE nybB ) => ( qwA.Value >= nybB.Value );
            public static bool operator >= ( QWORD qwA , Binary.BYTE bB ) => ( qwA.Value >= bB.Value );
            public static bool operator >= ( QWORD qwA , Binary.WORD wB ) => ( qwA.Value >= wB.Value );
            public static bool operator >= ( QWORD qwA , Binary.DWORD dwB ) => ( qwA.Value >= dwB.Value );
            public static bool operator >= ( QWORD qwA , QWORD qwB ) => ( qwA.Value >= qwB.Value );

            #endregion

            #region LessThanOrEqual

            public static bool operator <= ( QWORD qwA , byte bB ) => ( qwA.Value <= bB );
            public static bool operator <= ( QWORD qwA , ushort usB ) => ( qwA.Value <= usB );
            public static bool operator <= ( QWORD qwA , uint uiB ) => ( qwA.Value <= uiB );
            public static bool operator <= ( QWORD qwA , Binary.BIT bBit ) => ( qwA.Value <= bBit.Value );
            public static bool operator <= ( QWORD qwA , Binary.NYBLE nybB ) => ( qwA.Value <= nybB.Value );
            public static bool operator <= ( QWORD qwA , Binary.BYTE bB ) => ( qwA.Value <= bB.Value );
            public static bool operator <= ( QWORD qwA , Binary.WORD wB ) => ( qwA.Value <= wB.Value );
            public static bool operator <= ( QWORD qwA , Binary.DWORD dwB ) => ( qwA.Value <= dwB.Value );
            public static bool operator <= ( QWORD qwA , QWORD qwB ) => ( qwA.Value <= qwB.Value );

            #endregion

            #endregion
        }
    }
}
