using System;
using System.Collections.Generic;
using System.Text;

namespace EmuSandbox
{
    public class RAM
    {
        private Binary.WORD [ ] mbwMEMORY;

        public RAM(int iMemSize)
        {
            mbwMEMORY = new Binary.WORD [ iMemSize ];
        }

        public Binary.WORD this[int index]
        {
            get { return mbwMEMORY [ index ]; }
            set { mbwMEMORY [ index ] = value; }
        }
    }
}
