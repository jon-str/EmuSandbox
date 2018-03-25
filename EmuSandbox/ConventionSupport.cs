using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EmuSandbox
{
    public static class ConventionSupport
    {
        #region Properties

        private const string ErrorMsgPrefix = "[ERR]" + ConventionSupport.Space + ":" + ConventionSupport.Space;

        private const string msHexPrefix = "0x";
        private const string msBinaryPrefix = "0b";

        private const string Space = " ";

        private const string NewLine = "\n";

        private static StackTrace mStackTrace = null;

        private const int ciBitsPerByte  = 8;
        private const int ciBitsPerNyble = 4;

        private const int miMinDigits_ALL = 1;
        private const int miMaxDigits_HEX = 16;
        private const int miMaxDigits_BIN = 64;

        #endregion


        #region Accessors

        public static string HexPrefix
        {
            get { return ConventionSupport.msHexPrefix;  }
        }

        public static string BinaryPrefix
        {
            get { return ConventionSupport.msBinaryPrefix; }
        }

        public static int BitsPerByte
        {
            get { return ciBitsPerByte;  }
        }

        public static int BitsPerNyble
        {
            get { return ciBitsPerNyble; }
        }

        public static bool IsTypeEnum ( Type t_Type )
        {
            if ( t_Type.IsEnum )
            {
                return true;
            }
            return false;
        }

        public static int MinimumDigitsForToString { get { return miMinDigits_ALL;  } }
        public static int MaxiumHexDigitsForToString {  get { return miMaxDigits_HEX;  } }
        public static int MaxiumBinaryDigitsForToString { get { return miMaxDigits_BIN; } }

        #endregion

        #region Public Methods

        public static string ProduceErrorMsg ( StackTrace oStackTrace , string sMsg )
        {
            mStackTrace = oStackTrace;

            return ConventionSupport.ErrorMsgPrefix +
                   "[" + sMsg + "] " +
                   ConventionSupport.GetCurrentMethodFileName ( ) + ConventionSupport.Space +
                   ConventionSupport.GetCurrentMethodLineNumber ( ) + ConventionSupport.Space +
                   ConventionSupport.GetCurrentMethodName ( ) + ConventionSupport.Space +
                   ConventionSupport.NewLine;
        }

        public static string ProduceErrorMsg ( string sMsg , StackTrace oStackTrace )
        {
            return ProduceErrorMsg ( oStackTrace , sMsg );
        }

        public static string ProduceHexString(byte bValue)
        {
            return ProduceHexString ( bValue , 2 );
        }

        public static string ProduceHexString ( ushort usValue )
        {
            return ProduceHexString ( usValue , 4 );
        }

        public static string ProduceHexString ( uint uiValue )
        {
            return ProduceHexString ( ( uint ) uiValue , 8 );
        }

        public static string ProduceHexString ( ulong ulValue )
        {
            return ProduceHexString ( ulValue, 16 );
        }

        public static string ProduceHexString ( ulong iValue, int iNumHexDigits )
        {
            if(iNumHexDigits > ConventionSupport.MaxiumHexDigitsForToString || iNumHexDigits < ConventionSupport.MinimumDigitsForToString)
            {
                throw new Exception ( "ProduceHexString ( int iValue, int iNumHexDigits ): iNumHexDigits must be >= 1 or <= 16 -> was '" + iNumHexDigits.ToString ( ) + "'" );
            }

            return ConventionSupport.HexPrefix + iValue.ToString ( "X" + iNumHexDigits.ToString() );
        }

        public static string ProduceBinaryString ( ulong iValue , int iNumBinaryDigits )
        {
            if ( iNumBinaryDigits > ConventionSupport.MaxiumBinaryDigitsForToString || iNumBinaryDigits < ConventionSupport.MinimumDigitsForToString )
            {
                throw new Exception ( "ProduceBinaryString ( int iValue, int iNumBinaryDigits ): iNumBinaryDigits must be >= 1 or <= 16 -> was '" + iNumBinaryDigits.ToString ( ) + "'" );
            }

            return ConventionSupport.BinaryPrefix + Convert.ToString ( (int) iValue , 2 ).PadLeft ( iNumBinaryDigits , '0' );
        }


        public static string GetCurrentMethodLineNumber ( )
        {
            if ( mStackTrace == null )
            {
                return string.Empty;
            }

            StackFrame oStackFrame = mStackTrace.GetFrame ( 1 );

            return oStackFrame.GetFileLineNumber ( ).ToString ( );
        }

        public static string GetCurrentMethodFileName ( )
        {
            if ( mStackTrace == null )
            {
                return string.Empty;
            }

            StackFrame oStackFrame = mStackTrace.GetFrame ( 1 );

            return oStackFrame.GetFileName ( );
        }

        public static string GetCurrentMethodName ( )
        {
            if ( mStackTrace == null )
            {
                return string.Empty;
            }

            StackFrame oStackFrame = mStackTrace.GetFrame ( 1 );

            return oStackFrame.GetMethod ( ).Name;
        }

        #endregion

        //public class CON_SUPP_StringEnum : StringEnum
        //{
        //    #region Implementation


        //    #region Constructor
        //    public CON_SUPP_StringEnum ( Type tEnumType ) : base ( tEnumType , true )
        //    {

        //    }
        //    #endregion


        //    #region Public Methods

        //    public string HEX_GetStringValue ( string sValue )
        //    {
        //        return base.GetStringValue ( sValue ); //add hex wrapper
        //    }


        //    #endregion

        //    #endregion


        //    #region Private Methods
        //    #endregion


        //    #region Static

        //    //public string HEX_GetStringValue( Enum eValue )
        //    //{
        //    //    return StringEnum.GetStringValue(eValue);
        //    //}

        //    #endregion
        //}
    }
}
