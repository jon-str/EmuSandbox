using System;
using System.Collections.Generic;
using System.Text;

namespace EmuSandbox
{
    public class Register
    {
        private string msName;
        private Binary.BYTE mbbBinCode;

        Binary.WORD bwValue;

        public Register(string sName, byte bBinCode, ushort usValue)
        {
            msName = Name;
            mbbBinCode = new Binary.BYTE ( bBinCode );
            bwValue = new Binary.WORD ( usValue );
        }

        public ushort Value
        {
            get { return bwValue.Value; }
        }

        public Binary.WORD InnerValue
        {
            get { return bwValue; }
        }

        public string Name
        {
            get { return msName; }
        }
        public byte BinCode
        {
            get { return mbbBinCode.Value; }
        }
    }
    //public class Regs
    //{
    //    private string msName;
    //    private ushort musBinCode;
    //    private Binary.WORD mowValue;
    //    private ushort musValue;

    //    public Regs ( string sName , ushort sBinCode , ushort usValue )
    //    {
    //        new Regs ( sName , sBinCode , new Binary.WORD ( usValue ) );
    //        musValue = mowValue.Value;
    //    }

    //    public Regs ( string sName , ushort sBinCode )
    //    {
    //        new Regs ( sName , sBinCode , new Binary.WORD ( 0x0000 ) );
    //    }

    //    public Regs ( string sName , ushort sBinCode , Binary.WORD owValue )
    //    {
    //        msName = sName;
    //        musBinCode = sBinCode;
    //        mowValue = owValue;
    //    }

    //    public string Name
    //    {
    //        get { return msName; }
    //    }

    //    public ushort BinCode
    //    {
    //        get { return musBinCode; }
    //    }

    //    public ushort Value
    //    {
    //        get { return mowValue.Value; }
    //        set { mowValue = new Binary.WORD ( value ); }
    //    }

    //    public Binary.BYTE HighByte
    //    {
    //        get { return mowValue.HighByte; }
    //        set { mowValue.HighByte = value; }
    //    }

    //    public Binary.BYTE LowByte
    //    {
    //        get { return mowValue.LowByte; }
    //        set { mowValue.LowByte = value; }
    //    }

    //    public override string ToString ( )
    //    {
    //        return "[REG: " + this.Name + "] : [CODE: " + Convert.ToString ( this.BinCode , 2 ).PadLeft ( 4 , '0' ) + "] " + mowValue.ToString ( );
    //    }

    //    public void Dump ( )
    //    {
    //        Console.WriteLine ( this.ToString ( ) );
    //    }
    //}
}
