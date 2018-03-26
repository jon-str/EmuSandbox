using System;
using System.Collections.Generic;
using System.Text;

namespace EmuSandbox
{
    public static partial class Binary
    {
        public partial class BYTE : BinaryValue
        {
            #region Increment

            public static BYTE operator ++ ( BYTE bA ) => new BYTE ( ( bA.Value++ ) );

            #endregion

            #region Decrement

            public static BYTE operator -- ( BYTE bA ) => new BYTE ( ( bA.Value-- ) );

            #endregion

            #region Addition

            public static BYTE operator + ( BYTE bA , BYTE bB ) => new BYTE ( ( byte ) ( ( bA.Value + bB.Value ) ) ); 
            public static BYTE operator + ( BYTE bA , byte bB ) => new BYTE ( ( byte ) ( ( bA.Value + bB ) ) ); 
            public static BYTE operator + ( BYTE bA , Binary.NYBLE nybB ) => new BYTE ( ( byte ) ( ( bA.Value + nybB.Value ) ) ); 
            public static BYTE operator + ( BYTE bA , Binary.BIT bBit ) => new BYTE ( ( byte ) ( ( bA.Value + bBit.Value ) ) );

            #endregion

            #region Subtraction

            public static BYTE operator - ( BYTE bA , BYTE bB ) => new BYTE ( ( byte ) ( ( bA.Value - bB.Value ) ) ); 
            public static BYTE operator - ( BYTE bA , byte bB ) => new BYTE ( ( byte ) ( ( bA.Value - bB ) ) ); 
            public static BYTE operator - ( BYTE bA , Binary.NYBLE nybB ) => new BYTE ( ( byte ) ( ( bA.Value - nybB.Value ) ) ); 
            public static BYTE operator - ( BYTE bA , Binary.BIT bBit ) => new BYTE ( ( byte ) ( ( bA.Value - bBit.Value ) ) ); 

            #endregion

            #region Multiplication

            public static BYTE operator * ( BYTE bA , BYTE bB ) => new BYTE ( ( byte ) ( ( bA.Value * bB.Value ) ) ); 
            public static BYTE operator * ( BYTE bA , byte bB ) => new BYTE ( ( byte ) ( ( bA.Value * bB ) ) ); 
            public static BYTE operator * ( BYTE bA , Binary.NYBLE nybB ) => new BYTE ( ( byte ) ( ( bA.Value * nybB.Value ) ) ); 
            public static BYTE operator * ( BYTE bA , Binary.BIT bBit ) => new BYTE ( ( byte ) ( ( bA.Value * bBit.Value ) ) ); 

            #endregion

            #region Division

            public static BYTE operator / ( BYTE bA , BYTE bB ) => new BYTE ( ( byte ) ( ( bA.Value / bB.Value ) ) ); 
            public static BYTE operator / ( BYTE bA , byte bB ) => new BYTE ( ( byte ) ( ( bA.Value / bB ) ) ); 
            public static BYTE operator / ( BYTE bA , Binary.NYBLE nybB ) => new BYTE ( ( byte ) ( ( bA.Value / nybB.Value ) ) ); 
            public static BYTE operator / ( BYTE bA , Binary.BIT bBit ) => new BYTE ( ( byte ) ( ( bA.Value / bBit.Value ) ) );

            #endregion

            #region Modulo

            public static BYTE operator % ( BYTE bA , BYTE bB ) => new BYTE ( ( byte ) ( ( bA.Value % bB.Value ) ) );
            public static BYTE operator % ( BYTE bA , byte bB ) => new BYTE ( ( byte ) ( ( bA.Value % bB ) ) );
            public static BYTE operator % ( BYTE bA , Binary.NYBLE nybB ) => new BYTE ( ( byte ) ( ( bA.Value % nybB.Value ) ) );
            public static BYTE operator % ( BYTE bA , Binary.BIT bBit ) => new BYTE ( ( byte ) ( ( bA.Value % bBit.Value ) ) );

            #endregion

            #region Bitwise Operators

            #region AND

            public static BYTE operator & ( BYTE bA , BYTE bB ) => new BYTE ( ( byte ) ( ( bA.Value & bB.Value ) ) );
            public static BYTE operator & ( BYTE bA , byte bB ) => new BYTE ( ( byte ) ( ( bA.Value & bB ) ) );
            public static BYTE operator & ( BYTE bA , Binary.NYBLE nybB ) => new BYTE ( ( byte ) ( ( bA.Value & nybB.Value ) ) );
            public static BYTE operator & ( BYTE bA , Binary.BIT bBit ) => new BYTE ( ( byte ) ( ( bA.Value & bBit.Value ) ) );

            #endregion

            #region OR

            public static BYTE operator | ( BYTE bA , BYTE bB ) => new BYTE ( ( byte ) ( ( bA.Value | bB.Value ) ) );
            public static BYTE operator | ( BYTE bA , byte bB ) => new BYTE ( ( byte ) ( ( bA.Value | bB ) ) );
            public static BYTE operator | ( BYTE bA , Binary.NYBLE nybB ) => new BYTE ( ( byte ) ( ( bA.Value | nybB.Value ) ) );
            public static BYTE operator | ( BYTE bA , Binary.BIT bBit ) => new BYTE ( ( byte ) ( ( bA.Value | bBit.Value ) ) );

            #endregion

            #region XOR

            public static BYTE operator ^ ( BYTE bA , BYTE bB ) => new BYTE ( ( byte ) ( ( bA.Value ^ bB.Value ) ) );
            public static BYTE operator ^ ( BYTE bA , byte bB ) => new BYTE ( ( byte ) ( ( bA.Value ^ bB ) ) );
            public static BYTE operator ^ ( BYTE bA , Binary.NYBLE nybB ) => new BYTE ( ( byte ) ( ( bA.Value ^ nybB.Value ) ) );
            public static BYTE operator ^ ( BYTE bA , Binary.BIT bBit ) => new BYTE ( ( byte ) ( ( bA.Value ^ bBit.Value ) ) );

            #endregion

            #region COMPLEMENT

            public static BYTE operator ~ ( BYTE bA ) => new BYTE ( ( byte ) ( ( ~bA.Value ) ) );

            #endregion

            #region SHIFT_LEFT

            public static BYTE operator << ( BYTE bA , int iShiftBits ) => new BYTE ( ( byte ) ( ( bA.Value << iShiftBits ) ) );

            #endregion

            #region SHIFT_RIGHT

            public static BYTE operator >> ( BYTE bA , int iShiftBits ) => new BYTE ( ( byte ) ( ( bA.Value >> iShiftBits ) ) );

            #endregion

            #endregion

            #region Comparison Operators

            #region IsEqual

            public static bool operator == ( BYTE bA , BYTE bB ) => ( bA.Value == bB.Value );
            public static bool operator == ( BYTE bA , byte bB ) => ( bA.Value == bB );
            public static bool operator == ( BYTE bA , Binary.NYBLE nybB ) => ( bA.Value == nybB.Value );
            public static bool operator == ( BYTE bA , Binary.BIT bBit ) =>  ( bA.Value == bBit.Value );

            #endregion

            #region IsNotEqual

            public static bool operator != ( BYTE bA , BYTE bB ) => ( bA.Value != bB.Value );
            public static bool operator != ( BYTE bA , byte bB ) => ( bA.Value != bB );
            public static bool operator != ( BYTE bA , Binary.NYBLE nybB ) => ( bA.Value != nybB.Value );
            public static bool operator != ( BYTE bA , Binary.BIT bBit ) => ( bA.Value != bBit.Value );

            #endregion

            #region GreaterThan

            public static bool operator > ( BYTE bA , BYTE bB ) => ( bA.Value > bB.Value );
            public static bool operator > ( BYTE bA , byte bB ) => ( bA.Value > bB );
            public static bool operator > ( BYTE bA , Binary.NYBLE nybB ) => ( bA.Value > nybB.Value );
            public static bool operator > ( BYTE bA , Binary.BIT bBit ) => ( bA.Value > bBit.Value );

            #endregion

            #region LessThan

            public static bool operator < ( BYTE bA , BYTE bB ) => ( bA.Value < bB.Value );
            public static bool operator < ( BYTE bA , byte bB ) => ( bA.Value < bB );
            public static bool operator < ( BYTE bA , Binary.NYBLE nybB ) => ( bA.Value < nybB.Value );
            public static bool operator < ( BYTE bA , Binary.BIT bBit ) => ( bA.Value < bBit.Value );

            #endregion

            #region GreaterThanOrEqual

            public static bool operator >= ( BYTE bA , BYTE bB ) => ( bA.Value >= bB.Value );
            public static bool operator >= ( BYTE bA , byte bB ) => ( bA.Value >= bB );
            public static bool operator >= ( BYTE bA , Binary.NYBLE nybB ) => ( bA.Value >= nybB.Value );
            public static bool operator >= ( BYTE bA , Binary.BIT bBit ) => ( bA.Value >= bBit.Value );

            #endregion

            #region LessThanOrEqual

            public static bool operator <= ( BYTE bA , BYTE bB ) => ( bA.Value <= bB.Value );
            public static bool operator <= ( BYTE bA , byte bB ) => ( bA.Value <= bB );
            public static bool operator <= ( BYTE bA , Binary.NYBLE nybB ) => ( bA.Value <= nybB.Value );
            public static bool operator <= ( BYTE bA , Binary.BIT bBit ) => ( bA.Value <= bBit.Value );

            #endregion

            #endregion
        }
    }
}
