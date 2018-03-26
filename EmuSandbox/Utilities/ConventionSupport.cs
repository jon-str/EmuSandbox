using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EmuSandbox
{
    public static class ConventionSupport
    {
        #region Properties

        private const string cmsErrorMsgPrefix  = "[ERR]" + ConventionSupport.cmsSpace + ":" + ConventionSupport.cmsSpace;

        private const string cmsHexPrefix       = "0x";
        private const string cmsBinaryPrefix    = "0b";
        private const string cmsDecimalPrefix   = "0t";


        private const string cmsSpace = " ";

        private const string cmsNewLine = "\n";

        private const int cmiBitsPerByte  = 8;
        private const int cmiBitsPerNyble = 4;

        private const int cmiMinDigits_ALL = 1;
        private const int cmiMaxDigits_HEX = 16;
        private const int cmiMaxDigits_BIN = 64;

        private static StackTrace smStackTrace = null;

        private static Binary.BinaryValue.StringMode smbbvsmeStringMode = Binary.BinaryValue.StringMode.DEFAULT;

        #endregion

        #region Accessors

        public static Binary.BinaryValue.StringMode StringMode
        {
            get { return smbbvsmeStringMode; }
            set { smbbvsmeStringMode = value;  }
        }

        public static string NewLine {  get { return cmsNewLine; } }
        public static string Space {  get { return cmsSpace;  } }
        public static string ErrorMsgPrefix {  get { return cmsErrorMsgPrefix;  } }
        public static string HexPrefix { get { return ConventionSupport.cmsHexPrefix; } }
        public static string BinaryPrefix { get { return ConventionSupport.cmsBinaryPrefix; } }
        public static string DecimalPrefix { get { return ConventionSupport.cmsDecimalPrefix; } }
        public static int BitsPerByte { get { return cmiBitsPerByte; } }
        public static int BitsPerNyble { get { return cmiBitsPerNyble; } }
        public static int MinimumDigitsForToString { get { return cmiMinDigits_ALL;  } }
        public static int MaxiumHexDigitsForToString {  get { return cmiMaxDigits_HEX;  } }
        public static int MaxiumBinaryDigitsForToString { get { return cmiMaxDigits_BIN; } }

        #endregion

        #region Public Methods

        public static string ProduceErrorMsg ( string sMsg , StackTrace oStackTrace ) { return ProduceErrorMsg ( oStackTrace , sMsg ); }

        public static string ProduceErrorMsg ( StackTrace oStackTrace , string sMsg )
        {
            smStackTrace = oStackTrace;

            return ConventionSupport.cmsErrorMsgPrefix +
                   "[" + sMsg + "] " +
                   ConventionSupport.GetCurrentMethodFileName ( ) + ConventionSupport.cmsSpace +
                   ConventionSupport.GetCurrentMethodLineNumber ( ) + ConventionSupport.cmsSpace +
                   ConventionSupport.GetCurrentMethodName ( ) + ConventionSupport.cmsSpace +
                   ConventionSupport.cmsNewLine;
        }

        public static string ProduceHexString(byte bValue) { return ProduceHexString ( bValue , 2 ); }
        public static string ProduceHexString ( ushort usValue ) { return ProduceHexString ( usValue , 4 ); }
        public static string ProduceHexString ( uint uiValue ) { return ProduceHexString ( ( uint ) uiValue , 8 ); }
        public static string ProduceHexString ( ulong ulValue ) { return ProduceHexString ( ulValue , 16 ); }

        public static string ProduceHexString ( ulong iValue, int iNumHexDigits )
        {

            if(iNumHexDigits > ConventionSupport.MaxiumHexDigitsForToString || iNumHexDigits < ConventionSupport.MinimumDigitsForToString)
            {
                StackTrace oStackTrace = new StackTrace ( );

                string sMsg = string.Format ( "{0} ( int iValue, int iNumBinaryDigits ): iNumHexDigits must be >= {1} or <= {2} -> was '{3}'" ,
                              ConventionSupport.GetCurrentMethodName ( new StackTrace ( ) ) ,
                              ConventionSupport.MinimumDigitsForToString ,
                              ConventionSupport.MaxiumHexDigitsForToString ,
                              iNumHexDigits );

                throw new Exception ( ConventionSupport.ProduceErrorMsg ( oStackTrace , sMsg ) );
            }

            return ConventionSupport.HexPrefix + iValue.ToString ( "X" + iNumHexDigits.ToString() );
        }

        public static string ProduceBinaryNybleString ( byte bValue )   { return ProduceBinaryString ( bValue , 4 ); } // add warnings
        public static string ProduceBinaryByteString ( byte bValue )    { return ProduceBinaryString ( bValue , 8 ); } // add warnings

        // add warnings
        public static string ProduceBinaryString ( ushort usValue ) { return ProduceBinaryString ( usValue , 16 ); }
        public static string ProduceBinaryString ( uint uiValue )   { return ProduceBinaryString ( uiValue , 32 ); }
        public static string ProduceBinaryString ( ulong ulValue )  { return ProduceBinaryString ( ulValue , 64 ); }

        public static string ProduceBinaryString ( ulong iValue , int iNumBinaryDigits )
        {
            if ( iNumBinaryDigits > ConventionSupport.MaxiumBinaryDigitsForToString || iNumBinaryDigits < ConventionSupport.MinimumDigitsForToString )
            {
                StackTrace oStackTrace = new StackTrace ( );

                string sMsg = string.Format ( "{0} ( int iValue, int iNumBinaryDigits ): iNumBinaryDigits must be >= {1} or <= {2} -> was '{3}'" ,
                                              ConventionSupport.GetCurrentMethodName ( oStackTrace ) ,
                                              ConventionSupport.MinimumDigitsForToString ,
                                              ConventionSupport.MaxiumBinaryDigitsForToString ,
                                              iNumBinaryDigits );


                throw new Exception ( ConventionSupport.ProduceErrorMsg ( oStackTrace , sMsg ) );
            }

            return ConventionSupport.BinaryPrefix + Convert.ToString ( (int) iValue , 2 ).PadLeft ( iNumBinaryDigits , '0' );
        }

        public static string ProduceDecimalString( byte    bValue )     { return ConventionSupport.DecimalPrefix + bValue.ToString ( );  }
        public static string ProduceDecimalString ( ushort usValue )    { return ConventionSupport.DecimalPrefix + usValue.ToString ( ); }
        public static string ProduceDecimalString ( uint   uiValue )    { return ConventionSupport.DecimalPrefix + uiValue.ToString ( ); }
        public static string ProduceDecimalString ( ulong  ulValue )    { return ConventionSupport.DecimalPrefix + ulValue.ToString ( ); }

        public static string GetCurrentMethodLineNumber ( )
        {
            if ( smStackTrace == null )
            {
                return string.Empty;
            }

            StackFrame oStackFrame = smStackTrace.GetFrame ( 1 );

            return oStackFrame.GetFileLineNumber ( ).ToString ( );
        }

        public static string GetCurrentMethodFileName ( )
        {
            if ( smStackTrace == null )
            {
                return string.Empty;
            }

            StackFrame oStackFrame = smStackTrace.GetFrame ( 1 );

            return oStackFrame.GetFileName ( );
        }

        public static string GetCurrentMethodName ( )
        {
            if ( smStackTrace == null )
            {
                return string.Empty;
            }

            StackFrame oStackFrame = smStackTrace.GetFrame ( 1 );

            return oStackFrame.GetMethod ( ).Name;
        }

        public static string GetCurrentMethodName ( StackTrace oStackTrace )
        {
            smStackTrace = oStackTrace;

            StackFrame oStackFrame = smStackTrace.GetFrame ( 1 );

            return oStackFrame.GetMethod ( ).Name;
        }

        #endregion
    }
}
