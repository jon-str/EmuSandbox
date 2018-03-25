using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;

namespace EmuSandbox
{
    public class AssemblyGenerator
    {
        AppDomain oCurrentDomain = AppDomain.CurrentDomain;

        static AssemblyName asName = new AssemblyName ( "TempAssembly" );
        AssemblyBuilder asBuilder = AssemblyBuilder.DefineDynamicAssembly ( asName , AssemblyBuilderAccess.RunAndCollect );
    }
}
