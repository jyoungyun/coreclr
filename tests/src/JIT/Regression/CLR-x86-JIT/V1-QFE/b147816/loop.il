// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.


.assembly loop {}
.assembly extern mscorlib { }
.assembly extern System.Console
{
  .publickeytoken = (B0 3F 5F 7F 11 D5 0A 3A )
  .ver 4:0:0:0
}

.data D_a = bytearray (30 31 32 33)

.field public static int32 a at D_a

.method static public int32 main() cil managed
{ .entrypoint
  .maxstack  3
  .locals (int32* V_0)
  ldsflda    int32 a
  stloc.0                  // p = &a

  ldloc.0
  ldsflda    int32 a
  bge.un.s   Label_Exit    // Compare p and &a if they are equal (of course they should be equal, so following should be dead code)

Label_Loop:  
                           // Loop body. p += 4 and compare with &a
  ldloc.0
  ldc.i4.4
  add
  stloc.0
  ldloc.0
  ldsflda    int32 a
  blt.un.s   Label_Loop

Label_Exit:  
  ldstr "PASS"
  call void [System.Console]System.Console::WriteLine(class System.String)
  ldc.i4 100
  ret
}
