//-----------------------------------------------------------------------------
// Copyright (c) 2012 GarageGames, LLC
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to
// deal in the Software without restriction, including without limitation the
// rights to use, copy, modify, merge, publish, distribute, sublicense, and/or
// sell copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS
// IN THE SOFTWARE.
//-----------------------------------------------------------------------------

#include "core/strings/stringFunctions.h"
#include "console/console.h"
#include "console/engineAPI.h"

#include "math/mMath.h"


extern void mInstallLibrary_C();
extern void mInstallLibrary_ASM();
extern void mInstall_AMD_Math();
extern void mInstall_Library_SSE();

//--------------------------------------
ConsoleFunction( mathInit, void, 1, 10, "( ... )"
                "@brief Install the math library with specified extensions.\n\n"
                "Possible parameters are:\n\n"
                "    - 'DETECT' Autodetect math lib settings.\n\n"
                "    - 'C' Enable the C math routines. C routines are always enabled.\n\n"
                "    - 'FPU' Enable floating point unit routines.\n\n"
                "    - 'MMX' Enable MMX math routines.\n\n"
                "    - '3DNOW' Enable 3dNow! math routines.\n\n"
                "    - 'SSE' Enable SSE math routines.\n\n"
				"@ingroup Math")


{
   U32 properties = CPU_PROP_C;  // C entensions are always used

   if (argc == 1)
   {
         Math::init(0);
         return;
   }
   for (argc--, argv++; argc; argc--, argv++)
   {
      if (dStricmp(*argv, "DETECT") == 0) {
         Math::init(0);
         return;
      }
      if (dStricmp(*argv, "C") == 0) {
         properties |= CPU_PROP_C;
         continue;
      }
      if (dStricmp(*argv, "FPU") == 0) {
         properties |= CPU_PROP_FPU;
         continue;
      }
      if (dStricmp(*argv, "MMX") == 0) {
         properties |= CPU_PROP_MMX;
         continue;
      }
      if (dStricmp(*argv, "3DNOW") == 0) {
         properties |= CPU_PROP_3DNOW;
         continue;
      }
      if (dStricmp(*argv, "SSE") == 0) {
         properties |= CPU_PROP_SSE;
         continue;
      }
      Con::printf("Error: MathInit(): ignoring unknown math extension '%s'", *argv);
   }
   Math::init(properties);
}



//------------------------------------------------------------------------------
void Math::init(U32 properties)
{
   if (!properties)
      // detect what's available
      properties = Platform::SystemInfo.processor.properties;
   else
      // Make sure we're not asking for anything that's not supported
      properties &= Platform::SystemInfo.processor.properties;

   Con::printf("Math Init:");
   Con::printf("   Installing Standard C extensions");
   mInstallLibrary_C();

   Con::printf("   Installing Assembly extensions");
   mInstallLibrary_ASM();

   if (properties & CPU_PROP_FPU)
   {
      Con::printf("   Installing FPU extensions");
   }

   if (properties & CPU_PROP_MMX)
   {
      Con::printf("   Installing MMX extensions");
      if (properties & CPU_PROP_3DNOW)
      {
         Con::printf("   Installing 3DNow extensions");
         mInstall_AMD_Math();
      }
   }

   if (properties & CPU_PROP_SSE)
   {
      Con::printf("   Installing SSE extensions");
      mInstall_Library_SSE();
   }

   Con::printf(" ");
}


















































//---------------DNTC AUTO-GENERATED---------------//
#include <vector>

#include <string>

#include "core/strings/stringFunctions.h"

//---------------DO NOT MODIFY CODE BELOW----------//

extern "C" __declspec(dllexport) void  __cdecl wle_fn__mathInit(char * x__a1, char * x__a2, char * x__a3, char * x__a4, char * x__a5, char * x__a6, char * x__a7, char * x__a8, char * x__a9)
{
const char* a1 = (const char*)x__a1;
const char* a2 = (const char*)x__a2;
const char* a3 = (const char*)x__a3;
const char* a4 = (const char*)x__a4;
const char* a5 = (const char*)x__a5;
const char* a6 = (const char*)x__a6;
const char* a7 = (const char*)x__a7;
const char* a8 = (const char*)x__a8;
const char* a9 = (const char*)x__a9;
{
S32 argc = 10;
if (dStrlen(a9)==0)
if (dStrlen(a8)==0)
if (dStrlen(a7)==0)
if (dStrlen(a6)==0)
if (dStrlen(a5)==0)
if (dStrlen(a4)==0)
if (dStrlen(a3)==0)
if (dStrlen(a2)==0)
argc=2;
else
argc=3;
else
argc=4;
else
argc=5;
else
argc=6;
else
argc=7;
else
argc=8;
else
argc=9;
else
argc=10;
std::vector<const char*> arguments;
arguments.push_back("");
if (argc>=2)
arguments.push_back(a1);
if (argc>=3)
arguments.push_back(a2);
if (argc>=4)
arguments.push_back(a3);
if (argc>=5)
arguments.push_back(a4);
if (argc>=6)
arguments.push_back(a5);
if (argc>=7)
arguments.push_back(a6);
if (argc>=8)
arguments.push_back(a7);
if (argc>=9)
arguments.push_back(a8);
if (argc>=10)
arguments.push_back(a9);
const char** argv = &arguments[0];
{
   U32 properties = CPU_PROP_C;  
   if (argc == 1)
   {
         Math::init(0);
         return;
   }
   for (argc--, argv++; argc; argc--, argv++)
   {
      if (dStricmp(*argv, "DETECT") == 0) {
         Math::init(0);
         return;
      }
      if (dStricmp(*argv, "C") == 0) {
         properties |= CPU_PROP_C;
         continue;
      }
      if (dStricmp(*argv, "FPU") == 0) {
         properties |= CPU_PROP_FPU;
         continue;
      }
      if (dStricmp(*argv, "MMX") == 0) {
         properties |= CPU_PROP_MMX;
         continue;
      }
      if (dStricmp(*argv, "3DNOW") == 0) {
         properties |= CPU_PROP_3DNOW;
         continue;
      }
      if (dStricmp(*argv, "SSE") == 0) {
         properties |= CPU_PROP_SSE;
         continue;
      }
      Con::printf("Error: MathInit(): ignoring unknown math extension '%s'", *argv);
   }
   Math::init(properties);
}
}
}
//---------------END DNTC AUTO-GENERATED-----------//

