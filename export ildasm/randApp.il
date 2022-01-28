
//  Microsoft (R) .NET Framework IL Disassembler.  Version 4.8.3928.0




// Metadata version: v4.0.30319
.assembly extern System.Runtime
{
  .publickeytoken = (B0 3F 5F 7F 11 D5 0A 3A )                         // .?_....:
  .ver 4:2:2:0
}
.assembly extern System.Console
{
  .publickeytoken = (B0 3F 5F 7F 11 D5 0A 3A )                         // .?_....:
  .ver 4:1:2:0
}
.assembly extern System.Runtime.Extensions
{
  .publickeytoken = (B0 3F 5F 7F 11 D5 0A 3A )                         // .?_....:
  .ver 4:2:2:0
}
.assembly 'rand application'
{
  .custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [System.Runtime]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                                   63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.

  // --- Следующий настраиваемый атрибут добавлен автоматически, не следует отменять преобразование в комментарий -------
  //  .custom instance void [System.Runtime]System.Diagnostics.DebuggableAttribute::.ctor(valuetype [System.Runtime]System.Diagnostics.DebuggableAttribute/DebuggingModes) = ( 01 00 02 00 00 00 00 00 ) 

  .custom instance void [System.Runtime]System.Runtime.Versioning.TargetFrameworkAttribute::.ctor(string) = ( 01 00 18 2E 4E 45 54 43 6F 72 65 41 70 70 2C 56   // ....NETCoreApp,V
                                                                                                              65 72 73 69 6F 6E 3D 76 33 2E 31 01 00 54 0E 14   // ersion=v3.1..T..
                                                                                                              46 72 61 6D 65 77 6F 72 6B 44 69 73 70 6C 61 79   // FrameworkDisplay
                                                                                                              4E 61 6D 65 00 )                                  // Name.
  .custom instance void [System.Runtime]System.Reflection.AssemblyCompanyAttribute::.ctor(string) = ( 01 00 10 72 61 6E 64 20 61 70 70 6C 69 63 61 74   // ...rand applicat
                                                                                                      69 6F 6E 00 00 )                                  // ion..
  .custom instance void [System.Runtime]System.Reflection.AssemblyConfigurationAttribute::.ctor(string) = ( 01 00 07 52 65 6C 65 61 73 65 00 00 )             // ...Release..
  .custom instance void [System.Runtime]System.Reflection.AssemblyFileVersionAttribute::.ctor(string) = ( 01 00 07 31 2E 30 2E 30 2E 30 00 00 )             // ...1.0.0.0..
  .custom instance void [System.Runtime]System.Reflection.AssemblyInformationalVersionAttribute::.ctor(string) = ( 01 00 05 31 2E 30 2E 30 00 00 )                   // ...1.0.0..
  .custom instance void [System.Runtime]System.Reflection.AssemblyProductAttribute::.ctor(string) = ( 01 00 10 72 61 6E 64 20 61 70 70 6C 69 63 61 74   // ...rand applicat
                                                                                                      69 6F 6E 00 00 )                                  // ion..
  .custom instance void [System.Runtime]System.Reflection.AssemblyTitleAttribute::.ctor(string) = ( 01 00 10 72 61 6E 64 20 61 70 70 6C 69 63 61 74   // ...rand applicat
                                                                                                    69 6F 6E 00 00 )                                  // ion..
  .hash algorithm 0x00008004
  .ver 1:0:0:0
}
.module 'rand application.dll'
// MVID: {C9B89F6C-95EB-4508-A3D0-B3A7695004D9}
.imagebase 0x00400000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00000001    //  ILONLY
// Image base: 0x091D0000


// =============== CLASS MEMBERS DECLARATION ===================

.class private auto ansi beforefieldinit rand_application.Program
       extends [System.Runtime]System.Object
{
  .method private hidebysig static void  Main(string[] args) cil managed
  {
    .entrypoint
    // Размер кода:       17 (0x11)
    .maxstack  2
    .locals init (float64 V_0,
             float64 V_1)
    IL_0000:  ldloca.s   V_0
    IL_0002:  ldloca.s   V_1
    IL_0004:  call       void rand_application.Program::Input(float64&,
                                                              float64&)
    IL_0009:  ldloc.0
    IL_000a:  ldloc.1
    IL_000b:  call       void rand_application.Program::Calc(float64,
                                                             float64)
    IL_0010:  ret
  } // end of method Program::Main

  .method private hidebysig static void  Input([out] float64& OneValue,
                                               [out] float64& TwoValue) cil managed
  {
    // Размер кода:       45 (0x2d)
    .maxstack  8
    IL_0000:  ldstr      bytearray (12 04 32 04 35 04 34 04 38 04 42 04 35 04 20 00   // ..2.5.4.8.B.5. .
                                    3F 04 35 04 40 04 32 04 3E 04 35 04 20 00 47 04   // ?.5.@.2.>.5. .G.
                                    38 04 41 04 3B 04 3E 04 )                         // 8.A.;.>.
    IL_0005:  call       void [System.Console]System.Console::WriteLine(string)
    IL_000a:  ldarg.0
    IL_000b:  call       string [System.Console]System.Console::ReadLine()
    IL_0010:  call       float64 [System.Runtime.Extensions]System.Convert::ToDouble(string)
    IL_0015:  stind.r8
    IL_0016:  ldstr      bytearray (12 04 32 04 35 04 34 04 38 04 42 04 35 04 20 00   // ..2.5.4.8.B.5. .
                                    32 04 42 04 3E 04 40 04 3E 04 35 04 20 00 47 04   // 2.B.>.@.>.5. .G.
                                    38 04 41 04 3B 04 3E 04 )                         // 8.A.;.>.
    IL_001b:  call       void [System.Console]System.Console::WriteLine(string)
    IL_0020:  ldarg.1
    IL_0021:  call       string [System.Console]System.Console::ReadLine()
    IL_0026:  call       float64 [System.Runtime.Extensions]System.Convert::ToDouble(string)
    IL_002b:  stind.r8
    IL_002c:  ret
  } // end of method Program::Input

  .method private hidebysig static void  Calc(float64 One,
                                              float64 Two) cil managed
  {
    // Размер кода:       519 (0x207)
    .maxstack  2
    .locals init (float64 V_0,
             string V_1,
             uint32 V_2)
    IL_0000:  ldstr      bytearray (61 00 2D 00 41 04 43 04 3C 04 3C 04 30 04 0A 00   // a.-.A.C.<.<.0...
                                    62 00 2D 00 40 04 30 04 37 04 3D 04 3E 04 41 04   // b.-.@.0.7.=.>.A.
                                    42 04 4C 04 0A 00 63 00 2D 00 3F 04 40 04 3E 04   // B.L...c.-.?.@.>.
                                    38 04 37 04 32 04 35 04 34 04 35 04 3D 04 38 04   // 8.7.2.5.4.5.=.8.
                                    35 04 0A 00 64 00 2D 00 20 00 47 04 30 04 41 04   // 5...d.-. .G.0.A.
                                    42 04 3D 04 3E 04 35 04 0A 00 )                   // B.=.>.5...
    IL_0005:  call       void [System.Console]System.Console::WriteLine(string)
    IL_000a:  call       string [System.Console]System.Console::ReadLine()
    IL_000f:  stloc.1
    IL_0010:  ldloc.1
    IL_0011:  call       uint32 '<PrivateImplementationDetails>'::ComputeStringHash(string)
    IL_0016:  stloc.2
    IL_0017:  ldloc.2
    IL_0018:  ldc.i4     0xc405aacc
    IL_001d:  bgt.un.s   IL_0052

    IL_001f:  ldloc.2
    IL_0020:  ldc.i4     0x3d066947
    IL_0025:  bgt.un.s   IL_003e

    IL_0027:  ldloc.2
    IL_0028:  ldc.i4     0x37065fd5
    IL_002d:  beq        IL_00f0

    IL_0032:  ldloc.2
    IL_0033:  ldc.i4     0x3d066947
    IL_0038:  beq        IL_00ce

    IL_003d:  ret

    IL_003e:  ldloc.2
    IL_003f:  ldc.i4     0xc105a613
    IL_0044:  beq.s      IL_00bd

    IL_0046:  ldloc.2
    IL_0047:  ldc.i4     0xc405aacc
    IL_004c:  beq        IL_00df

    IL_0051:  ret

    IL_0052:  ldloc.2
    IL_0053:  ldc.i4     0xe40c292c
    IL_0058:  bgt.un.s   IL_006b

    IL_005a:  ldloc.2
    IL_005b:  ldc.i4     0xe10c2473
    IL_0060:  beq.s      IL_00ac

    IL_0062:  ldloc.2
    IL_0063:  ldc.i4     0xe40c292c
    IL_0068:  beq.s      IL_007c

    IL_006a:  ret

    IL_006b:  ldloc.2
    IL_006c:  ldc.i4     0xe60c2c52
    IL_0071:  beq.s      IL_009b

    IL_0073:  ldloc.2
    IL_0074:  ldc.i4     0xe70c2de5
    IL_0079:  beq.s      IL_008a

    IL_007b:  ret

    IL_007c:  ldloc.1
    IL_007d:  ldstr      "a"
    IL_0082:  call       bool [System.Runtime]System.String::op_Equality(string,
                                                                         string)
    IL_0087:  brtrue.s   IL_0101

    IL_0089:  ret

    IL_008a:  ldloc.1
    IL_008b:  ldstr      "b"
    IL_0090:  call       bool [System.Runtime]System.String::op_Equality(string,
                                                                         string)
    IL_0095:  brtrue     IL_011c

    IL_009a:  ret

    IL_009b:  ldloc.1
    IL_009c:  ldstr      "c"
    IL_00a1:  call       bool [System.Runtime]System.String::op_Equality(string,
                                                                         string)
    IL_00a6:  brtrue     IL_0137

    IL_00ab:  ret

    IL_00ac:  ldloc.1
    IL_00ad:  ldstr      "d"
    IL_00b2:  call       bool [System.Runtime]System.String::op_Equality(string,
                                                                         string)
    IL_00b7:  brtrue     IL_0152

    IL_00bc:  ret

    IL_00bd:  ldloc.1
    IL_00be:  ldstr      bytearray (44 04 )                                           // D.
    IL_00c3:  call       bool [System.Runtime]System.String::op_Equality(string,
                                                                         string)
    IL_00c8:  brtrue     IL_0184

    IL_00cd:  ret

    IL_00ce:  ldloc.1
    IL_00cf:  ldstr      bytearray (38 04 )                                           // 8.
    IL_00d4:  call       bool [System.Runtime]System.String::op_Equality(string,
                                                                         string)
    IL_00d9:  brtrue     IL_019f

    IL_00de:  ret

    IL_00df:  ldloc.1
    IL_00e0:  ldstr      bytearray (41 04 )                                           // A.
    IL_00e5:  call       bool [System.Runtime]System.String::op_Equality(string,
                                                                         string)
    IL_00ea:  brtrue     IL_01ba

    IL_00ef:  ret

    IL_00f0:  ldloc.1
    IL_00f1:  ldstr      bytearray (32 04 )                                           // 2.
    IL_00f6:  call       bool [System.Runtime]System.String::op_Equality(string,
                                                                         string)
    IL_00fb:  brtrue     IL_01d5

    IL_0100:  ret

    IL_0101:  ldarg.0
    IL_0102:  ldarg.1
    IL_0103:  add
    IL_0104:  stloc.0
    IL_0105:  ldstr      bytearray (43 00 43 04 3C 04 3C 04 30 04 20 00 47 04 38 04   // C.C.<.<.0. .G.8.
                                    41 04 35 04 3B 04 3A 00 20 00 )                   // A.5.;.:. .
    IL_010a:  ldloca.s   V_0
    IL_010c:  call       instance string [System.Runtime]System.Double::ToString()
    IL_0111:  call       string [System.Runtime]System.String::Concat(string,
                                                                      string)
    IL_0116:  call       void [System.Console]System.Console::WriteLine(string)
    IL_011b:  ret

    IL_011c:  ldarg.0
    IL_011d:  ldarg.1
    IL_011e:  sub
    IL_011f:  stloc.0
    IL_0120:  ldstr      bytearray (20 04 30 04 37 04 3D 04 3E 04 41 04 42 04 4C 04   //  .0.7.=.>.A.B.L.
                                    20 00 47 04 38 04 41 04 35 04 3B 04 3A 00 20 00 ) //  .G.8.A.5.;.:. .
    IL_0125:  ldloca.s   V_0
    IL_0127:  call       instance string [System.Runtime]System.Double::ToString()
    IL_012c:  call       string [System.Runtime]System.String::Concat(string,
                                                                      string)
    IL_0131:  call       void [System.Console]System.Console::WriteLine(string)
    IL_0136:  ret

    IL_0137:  ldarg.0
    IL_0138:  ldarg.1
    IL_0139:  mul
    IL_013a:  stloc.0
    IL_013b:  ldstr      bytearray (1F 04 40 04 3E 04 38 04 37 04 32 04 35 04 34 04   // ..@.>.8.7.2.5.4.
                                    35 04 3D 04 38 04 35 04 20 00 47 04 38 04 41 04   // 5.=.8.5. .G.8.A.
                                    35 04 3B 04 3A 00 20 00 )                         // 5.;.:. .
    IL_0140:  ldloca.s   V_0
    IL_0142:  call       instance string [System.Runtime]System.Double::ToString()
    IL_0147:  call       string [System.Runtime]System.String::Concat(string,
                                                                      string)
    IL_014c:  call       void [System.Console]System.Console::WriteLine(string)
    IL_0151:  ret

    IL_0152:  ldarg.1
    IL_0153:  ldc.r8     0.0
    IL_015c:  bne.un.s   IL_0169

    IL_015e:  ldstr      bytearray (14 04 35 04 3B 04 38 04 42 04 4C 04 20 00 3D 04   // ..5.;.8.B.L. .=.
                                    30 04 20 00 3D 04 3E 04 3B 04 4C 04 20 00 3D 04   // 0. .=.>.;.L. .=.
                                    35 04 3B 04 4C 04 37 04 4F 04 )                   // 5.;.L.7.O.
    IL_0163:  call       void [System.Console]System.Console::WriteLine(string)
    IL_0168:  ret

    IL_0169:  ldarg.0
    IL_016a:  ldarg.1
    IL_016b:  div
    IL_016c:  stloc.0
    IL_016d:  ldstr      bytearray (27 04 30 04 41 04 42 04 3D 04 3E 04 35 04 20 00   // '.0.A.B.=.>.5. .
                                    47 04 38 04 41 04 35 04 3B 04 3A 00 20 00 )       // G.8.A.5.;.:. .
    IL_0172:  ldloca.s   V_0
    IL_0174:  call       instance string [System.Runtime]System.Double::ToString()
    IL_0179:  call       string [System.Runtime]System.String::Concat(string,
                                                                      string)
    IL_017e:  call       void [System.Console]System.Console::WriteLine(string)
    IL_0183:  ret

    IL_0184:  ldarg.0
    IL_0185:  ldarg.1
    IL_0186:  add
    IL_0187:  stloc.0
    IL_0188:  ldstr      bytearray (43 00 43 04 3C 04 3C 04 30 04 20 00 47 04 38 04   // C.C.<.<.0. .G.8.
                                    41 04 35 04 3B 04 3A 00 20 00 )                   // A.5.;.:. .
    IL_018d:  ldloca.s   V_0
    IL_018f:  call       instance string [System.Runtime]System.Double::ToString()
    IL_0194:  call       string [System.Runtime]System.String::Concat(string,
                                                                      string)
    IL_0199:  call       void [System.Console]System.Console::WriteLine(string)
    IL_019e:  ret

    IL_019f:  ldarg.0
    IL_01a0:  ldarg.1
    IL_01a1:  sub
    IL_01a2:  stloc.0
    IL_01a3:  ldstr      bytearray (20 04 30 04 37 04 3D 04 3E 04 41 04 42 04 4C 04   //  .0.7.=.>.A.B.L.
                                    20 00 47 04 38 04 41 04 35 04 3B 04 3A 00 20 00 ) //  .G.8.A.5.;.:. .
    IL_01a8:  ldloca.s   V_0
    IL_01aa:  call       instance string [System.Runtime]System.Double::ToString()
    IL_01af:  call       string [System.Runtime]System.String::Concat(string,
                                                                      string)
    IL_01b4:  call       void [System.Console]System.Console::WriteLine(string)
    IL_01b9:  ret

    IL_01ba:  ldarg.0
    IL_01bb:  ldarg.1
    IL_01bc:  mul
    IL_01bd:  stloc.0
    IL_01be:  ldstr      bytearray (1F 04 40 04 3E 04 38 04 37 04 32 04 35 04 34 04   // ..@.>.8.7.2.5.4.
                                    35 04 3D 04 38 04 35 04 20 00 47 04 38 04 41 04   // 5.=.8.5. .G.8.A.
                                    35 04 3B 04 3A 00 20 00 )                         // 5.;.:. .
    IL_01c3:  ldloca.s   V_0
    IL_01c5:  call       instance string [System.Runtime]System.Double::ToString()
    IL_01ca:  call       string [System.Runtime]System.String::Concat(string,
                                                                      string)
    IL_01cf:  call       void [System.Console]System.Console::WriteLine(string)
    IL_01d4:  ret

    IL_01d5:  ldarg.1
    IL_01d6:  ldc.r8     0.0
    IL_01df:  bne.un.s   IL_01ec

    IL_01e1:  ldstr      bytearray (14 04 35 04 3B 04 38 04 42 04 4C 04 20 00 3D 04   // ..5.;.8.B.L. .=.
                                    30 04 20 00 3D 04 3E 04 3B 04 4C 04 20 00 3D 04   // 0. .=.>.;.L. .=.
                                    35 04 3B 04 4C 04 37 04 4F 04 )                   // 5.;.L.7.O.
    IL_01e6:  call       void [System.Console]System.Console::WriteLine(string)
    IL_01eb:  ret

    IL_01ec:  ldarg.0
    IL_01ed:  ldarg.1
    IL_01ee:  div
    IL_01ef:  stloc.0
    IL_01f0:  ldstr      bytearray (27 04 30 04 41 04 42 04 3D 04 3E 04 35 04 20 00   // '.0.A.B.=.>.5. .
                                    47 04 38 04 41 04 35 04 3B 04 3A 00 20 00 )       // G.8.A.5.;.:. .
    IL_01f5:  ldloca.s   V_0
    IL_01f7:  call       instance string [System.Runtime]System.Double::ToString()
    IL_01fc:  call       string [System.Runtime]System.String::Concat(string,
                                                                      string)
    IL_0201:  call       void [System.Console]System.Console::WriteLine(string)
    IL_0206:  ret
  } // end of method Program::Calc

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Размер кода:       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [System.Runtime]System.Object::.ctor()
    IL_0006:  ret
  } // end of method Program::.ctor

} // end of class rand_application.Program

.class private auto ansi sealed '<PrivateImplementationDetails>'
       extends [System.Runtime]System.Object
{
  .custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .method assembly hidebysig static uint32 
          ComputeStringHash(string s) cil managed
  {
    // Размер кода:       44 (0x2c)
    .maxstack  2
    .locals init (uint32 V_0,
             int32 V_1)
    IL_0000:  ldarg.0
    IL_0001:  brfalse.s  IL_002a

    IL_0003:  ldc.i4     0x811c9dc5
    IL_0008:  stloc.0
    IL_0009:  ldc.i4.0
    IL_000a:  stloc.1
    IL_000b:  br.s       IL_0021

    IL_000d:  ldarg.0
    IL_000e:  ldloc.1
    IL_000f:  callvirt   instance char [System.Runtime]System.String::get_Chars(int32)
    IL_0014:  ldloc.0
    IL_0015:  xor
    IL_0016:  ldc.i4     0x1000193
    IL_001b:  mul
    IL_001c:  stloc.0
    IL_001d:  ldloc.1
    IL_001e:  ldc.i4.1
    IL_001f:  add
    IL_0020:  stloc.1
    IL_0021:  ldloc.1
    IL_0022:  ldarg.0
    IL_0023:  callvirt   instance int32 [System.Runtime]System.String::get_Length()
    IL_0028:  blt.s      IL_000d

    IL_002a:  ldloc.0
    IL_002b:  ret
  } // end of method '<PrivateImplementationDetails>'::ComputeStringHash

} // end of class '<PrivateImplementationDetails>'


// =============================================================

// *********** ДИЗАССЕМБЛИРОВАНИЕ ЗАВЕРШЕНО ***********************
// ВНИМАНИЕ: создан файл ресурсов Win32 E:\Geek Brain\7 zadanie\export ildasm\randApp.res
