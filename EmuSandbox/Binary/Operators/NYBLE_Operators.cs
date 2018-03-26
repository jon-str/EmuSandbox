using System;
using System.Collections.Generic;
using System.Text;

namespace EmuSandbox
{
    public static partial class Binary
    {
        public partial class NYBLE : BinaryValue
        {
            #region Increment

            public static NYBLE operator ++ ( NYBLE nybA ) => new NYBLE ( ( nybA.Value++ ) );

            #endregion

            #region Decrement

            public static NYBLE operator -- ( NYBLE nybA ) => new NYBLE ( ( nybA.Value-- ) );

            #endregion

            #region Addition

            public static NYBLE operator + ( NYBLE nybA , Binary.BIT bBit ) => new NYBLE ( ( byte ) ( ( nybA.Value + bBit.Value ) ) );
            public static NYBLE operator + ( NYBLE nybA , NYBLE nybB ) => new NYBLE ( ( byte ) ( ( nybA.Value + nybB.Value ) ) );
            public static NYBLE operator + ( NYBLE nybA , byte bB ) => new NYBLE ( ( byte ) ( ( nybA.Value + bB ) ) );

            #endregion

            #region Subtraction

            public static NYBLE operator - ( NYBLE nybA , Binary.BIT bBit ) => new NYBLE ( ( byte ) ( ( nybA.Value - bBit.Value ) ) );
            public static NYBLE operator - ( NYBLE nybA , NYBLE nybB ) => new NYBLE ( ( byte ) ( ( nybA.Value - nybB.Value ) ) );
            public static NYBLE operator - ( NYBLE nybA , byte bB ) => new NYBLE ( ( byte ) ( ( nybA.Value - bB ) ) );

            #endregion

            #region Multiplication

            public static NYBLE operator * ( NYBLE nybA , Binary.BIT bBit ) => new NYBLE ( ( byte ) ( ( nybA.Value * bBit.Value ) ) );
            public static NYBLE operator * ( NYBLE nybA , NYBLE nybB ) => new NYBLE ( ( byte ) ( ( nybA.Value * nybB.Value ) ) );
            public static NYBLE operator * ( NYBLE nybA , byte bB ) => new NYBLE ( ( byte ) ( ( nybA.Value * bB ) ) );

            #endregion

            #region Division

            public static NYBLE operator / ( NYBLE nybA , Binary.BIT bBit ) => new NYBLE ( ( byte ) ( ( nybA.Value / bBit.Value ) ) );
            public static NYBLE operator / ( NYBLE nybA , NYBLE nybB ) => new NYBLE ( ( byte ) ( ( nybA.Value / nybB.Value ) ) );
            public static NYBLE operator / ( NYBLE nybA , byte bB ) => new NYBLE ( ( byte ) ( ( nybA.Value / bB ) ) );

            #endregion

            #region Modulo

            public static NYBLE operator % ( NYBLE nybA , Binary.BIT bBit ) => new NYBLE ( ( byte ) ( ( nybA.Value % bBit.Value ) ) );
            public static NYBLE operator % ( NYBLE nybA , NYBLE nybB ) => new NYBLE ( ( byte ) ( ( nybA.Value % nybB.Value ) ) );
            public static NYBLE operator % ( NYBLE nybA , byte bB ) => new NYBLE ( ( byte ) ( ( nybA.Value % bB ) ) );

            #endregion

            #region Bitwise Operators

            #region AND

            public static NYBLE operator & ( NYBLE nybA , Binary.BIT bBit ) => new NYBLE ( ( byte ) ( ( nybA.Value & bBit.Value ) ) );
            public static NYBLE operator & ( NYBLE nybA , NYBLE nybB ) => new NYBLE ( ( byte ) ( ( nybA.Value & nybB.Value ) ) );
            public static NYBLE operator & ( NYBLE nybA , byte bB ) => new NYBLE ( ( byte ) ( ( nybA.Value & bB ) ) );

            #endregion

            #region OR

            public static NYBLE operator | ( NYBLE nybA , Binary.BIT bBit ) => new NYBLE ( ( byte ) ( ( nybA.Value | bBit.Value ) ) );
            public static NYBLE operator | ( NYBLE nybA , NYBLE nybB ) => new NYBLE ( ( byte ) ( ( nybA.Value | nybB.Value ) ) );
            public static NYBLE operator | ( NYBLE nybA , byte bB ) => new NYBLE ( ( byte ) ( ( nybA.Value | bB ) ) );

            #endregion

            #region XOR

            public static NYBLE operator ^ ( NYBLE nybA , Binary.BIT bBit ) => new NYBLE ( ( byte ) ( ( nybA.Value ^ bBit.Value ) ) );
            public static NYBLE operator ^ ( NYBLE nybA , NYBLE nybB ) => new NYBLE ( ( byte ) ( ( nybA.Value ^ nybB.Value ) ) );
            public static NYBLE operator ^ ( NYBLE nybA , byte bB ) => new NYBLE ( ( byte ) ( ( nybA.Value ^ bB ) ) );

            #endregion

            #region COMPLEMENT

            public static NYBLE operator ~ ( NYBLE nybA ) => new NYBLE ( ( byte ) ( ( ~nybA.Value ) ) );

            #endregion

            #region SHIFT_LEFT

            public static NYBLE operator << ( NYBLE nybA , int iShiftBits ) => new NYBLE ( ( byte ) ( ( nybA.Value << iShiftBits ) ) );

            #endregion

            #region SHIFT_RIGHT

            public static NYBLE operator >> ( NYBLE nybA , int iShiftBits ) => new NYBLE ( ( byte ) ( ( nybA.Value >> iShiftBits ) ) );

            #endregion

            #endregion

            #region Comparison Operators

            #region IsEqual

            public static bool operator == ( NYBLE nybA , Binary.BIT bBit ) => ( nybA.Value == bBit.Value );
            public static bool operator == ( NYBLE nybA , NYBLE nybB ) => ( nybA.Value == nybB.Value );
            public static bool operator == ( NYBLE nybA , byte bB ) => ( nybA.Value == bB );

            #endregion

            #region IsNotEqual

            public static bool operator != ( NYBLE nybA , Binary.BIT bBit ) => ( nybA.Value != bBit.Value );
            public static bool operator != ( NYBLE nybA , NYBLE nybB ) => ( nybA.Value != nybB.Value );
            public static bool operator != ( NYBLE nybA , byte bB ) => ( nybA.Value != bB );

            #endregion

            #region GreaterThan

            public static bool operator > ( NYBLE nybA , Binary.BIT bBit ) => ( nybA.Value > bBit.Value );
            public static bool operator > ( NYBLE nybA , NYBLE nybB ) => ( nybA.Value > nybB.Value );
            public static bool operator > ( NYBLE nybA , byte bB ) => ( nybA.Value > bB );

            #endregion

            #region LessThan

            public static bool operator < ( NYBLE nybA , Binary.BIT bBit ) => ( nybA.Value < bBit.Value );
            public static bool operator < ( NYBLE nybA , NYBLE nybB ) => ( nybA.Value < nybB.Value );
            public static bool operator < ( NYBLE nybA , byte bB ) => ( nybA.Value < bB );

            #endregion

            #region GreaterThanOrEqual

            public static bool operator >= ( NYBLE nybA , Binary.BIT bBit ) => ( nybA.Value >= bBit.Value );
            public static bool operator >= ( NYBLE nybA , NYBLE nybB ) => ( nybA.Value >= nybB.Value );
            public static bool operator >= ( NYBLE nybA , byte bB ) => ( nybA.Value >= bB );

            #endregion

            #region LessThanOrEqual

            public static bool operator <= ( NYBLE nybA , Binary.BIT bBit ) => ( nybA.Value <= bBit.Value );
            public static bool operator <= ( NYBLE nybA , NYBLE nybB ) => ( nybA.Value <= nybB.Value );
            public static bool operator <= ( NYBLE nybA , byte bB ) => ( nybA.Value <= bB );

            #endregion

            #endregion
        }
    }
}
