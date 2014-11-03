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
#include "math/mMathFn.h"
#include "math/mRandom.h"

#include "console/engineAPI.h"


DefineConsoleFunction( mSolveQuadratic, const char*, ( F32 a, F32 b, F32 c ),,
    "Solve a quadratic equation (2nd degree polynomial) of form a*x^2 + b*x + c = 0.\n"
    "@param a First Coefficient."
    "@param b Second Coefficient."
    "@param c Third Coefficient."
    "@returns A triple, containing: (sol x0 x1). (sol) is the number of solutions"
    "(being 0, 1, or 2), and (x0) and (x1) are the solutions, if any."
    "@ingroup Math" )
{
   F32 x[2];
   U32 sol = mSolveQuadratic( a, b, c, x );

   static const U32 bufSize = 256;
   char * retBuffer = Con::getReturnBuffer(bufSize);
   dSprintf(retBuffer, bufSize, "%d %g %g", sol, x[0], x[1]);
   return retBuffer;
}

DefineConsoleFunction( mSolveCubic, const char*, ( F32 a, F32 b, F32 c, F32 d ),,
    "Solve a cubic equation (3rd degree polynomial) of form a*x^3 + b*x^2 + c*x + d = 0.\n"
    "@param a First Coefficient."
    "@param b Second Coefficient."
    "@param c Third Coefficient."
    "@param d Fourth Coefficient."
    "@returns A 4-tuple, containing: (sol x0 x1 x2). (sol) is the number of solutions"
    "(being 0, 1, 2 or 3), and (x0), (x1) and (x2) are the solutions, if any."
    "@ingroup Math" )
{    
   F32 x[3];
   U32 sol = mSolveCubic( a, b, c, d, x );

   static const U32 bufSize = 256;
   char * retBuffer = Con::getReturnBuffer(bufSize);
   dSprintf(retBuffer, bufSize, "%d %g %g %g", sol, x[0], x[1], x[2]);
   return retBuffer;
}

DefineConsoleFunction( mSolveQuartic, const char*, ( F32 a, F32 b, F32 c, F32 d, F32 e ),,
    "Solve a quartic equation (4th degree polynomial) of form a*x^4 + b*x^3 + c*x^2 + d*x + e = 0.\n"
    "@param a First Coefficient."
    "@param b Second Coefficient."
    "@param c Third Coefficient."
    "@param d Fourth Coefficient."
    "@param e Fifth Coefficient."
    "@returns A 5-tuple, containing: (sol x0 x1 x2 c3). (sol) is the number of solutions"
    "(being 0, 1, 2, 3 or 4), and (x0), (x1), (x2) and (x3) are the solutions, if any."
    "@ingroup Math" )
{
   F32 x[4];
   static const U32 bufSize = 256;
   char * retBuffer = Con::getReturnBuffer(bufSize);
   U32 sol = mSolveQuartic(a, b, c, d, e, x);
   dSprintf(retBuffer, 256, "%d %g %g %g %g", sol, x[0], x[1], x[2], x[3]);
   return retBuffer;
}

DefineConsoleFunction( mFloor, S32, ( F32 v ),,
    "Round v down to the nearest integer.\n"
    "@param v Number to convert to integer."
    "@returns Number converted to integer."
    "@ingroup Math" )
{
   return (S32)mFloor( v );
}

DefineConsoleFunction( mRound, F32, ( F32 v, S32 n ), (0),  
    "Round v to the nth decimal place or the nearest whole number by default."  
    "@param v Value to roundn"  
    "@param n Number of decimal places to round to, 0 by defaultn"  
    "@return The rounded value as a S32."  
    "@ingroup Math" )  
{  
    if(n <= 0)
	{
        return mRound(v);  
	}
    else  
	{
        return mRound(v, n);  
	}
}  

DefineConsoleFunction( mCeil, S32, ( F32 v ),,
    "Round v up to the nearest integer.\n"
    "@param v Number to convert to integer."
    "@returns Number converted to integer."
    "@ingroup Math" )
{
   return (S32)mCeil( v );
}

DefineConsoleFunction( mFloatLength, const char*, ( F32 v, U32 precision ),,
    "Formats the specified number to the given number of decimal places.\n"
    "@param v Number to format."
    "@param precision Number of decimal places to format to (1-9)."
    "@returns Number formatted to the specified number of decimal places."
    "@ingroup Math" )
{
   char fmtString[8] = "%.9f";

   if (precision >= 9)
      precision = 9;
   fmtString[2] = '0' + precision;

   static const U32 bufSize = 256;
   char * outBuffer = Con::getReturnBuffer(bufSize);
   dSprintf(outBuffer, bufSize, fmtString, v);
   return outBuffer;
}

//------------------------------------------------------------------------------

DefineConsoleFunction( mAbs, F32, ( F32 v ),,
    "Calculate absolute value of specified value.\n"
    "@param v Input Value."
    "@returns Absolute value of specified value."
    "@ingroup Math" )
{
   return mFabs( v );
}

DefineConsoleFunction( mFMod, F32, ( F32 v, F32 d ),,
    "Calculate the remainder of v/d.\n"
    "@param v Input Value."
    "@param d Divisor Value."
    "@returns The remainder of v/d."
    "@ingroup Math" )
{
   return mFmod( v, d );
}

DefineConsoleFunction( mSqrt, F32, ( F32 v ),,
    "Calculate the square-root of v.\n"
    "@param v Input Value."
    "@returns The square-root of the input value."
    "@ingroup Math" )
{
   return mSqrt (v );
}

DefineConsoleFunction( mPow, F32, ( F32 v, F32 p ),,
    "Calculate b raised to the p-th power.\n"
    "@param v Input Value."
    "@param p Power to raise value by."
    "@returns v raised to the p-th power."
    "@ingroup Math" )
{
   return mPow( v, p );
}

DefineConsoleFunction( mLog, F32, ( F32 v ),,
    "Calculate the natural logarithm of v.\n"
    "@param v Input Value."
    "@returns The natural logarithm of the input value."
    "@ingroup Math" )
{
   return mLog( v );
}

DefineConsoleFunction( mSin, F32, ( F32 v ),,
    "Calculate the sine of v.\n"
    "@param v Input Value (in radians)."
    "@returns The sine of the input value."
    "@ingroup Math" )
{
   return mSin( v );
}

DefineConsoleFunction( mCos, F32, ( F32 v ),,
    "Calculate the cosine of v.\n"
    "@param v Input Value (in radians)."
    "@returns The cosine of the input value."
    "@ingroup Math" )
{
   return mCos( v );
}

DefineConsoleFunction( mTan, F32, ( F32 v ),,
    "Calculate the tangent of v.\n"
    "@param v Input Value (in radians)."
    "@returns The tangent of the input value."
    "@ingroup Math" )
{
   return mTan( v );
}

DefineConsoleFunction( mAsin, F32, ( F32 v ),,
    "Calculate the arc-sine of v.\n"
    "@param v Input Value (in radians)."
    "@returns The arc-sine of the input value."
    "@ingroup Math" )
{
   return mAsin( v );
}

DefineConsoleFunction( mAcos, F32, ( F32 v ),,
    "Calculate the arc-cosine of v.\n"
    "@param v Input Value (in radians)."
    "@returns The arc-cosine of the input value."
    "@ingroup Math" )
{
   return mAcos( v );
}

DefineConsoleFunction( mAtan, F32, ( F32 rise, F32 run ),,
    "Calculate the arc-tangent (slope) of a line defined by rise and run.\n"
    "@param rise of line."
    "@param run of line."
    "@returns The arc-tangent (slope) of a line defined by rise and run."
    "@ingroup Math" )
{
   return mAtan2( rise, run );
}

DefineConsoleFunction( mRadToDeg, F32, ( F32 radians ),,
    "Convert specified radians into degrees.\n"
    "@param radians Input Value (in radians)."
    "@returns The specified radians value converted to degrees."
    "@ingroup Math" )
{
   return mRadToDeg( radians );
}

DefineConsoleFunction( mDegToRad, F32, ( F32 degrees ),,
    "Convert specified degrees into radians.\n"
    "@param degrees Input Value (in degrees)."
    "@returns The specified degrees value converted to radians."
    "@ingroup Math" )
{
   return mDegToRad( degrees );
}

DefineConsoleFunction( mClamp, F32, ( F32 v, F32 min, F32 max ),,
    "Clamp the specified value between two bounds.\n"
    "@param v Input value."
    "@param min Minimum Bound."
    "@param max Maximum Bound."
    "@returns The specified value clamped to the specified bounds."
    "@ingroup Math" )
{
   return mClampF( v, min, max );
}

DefineConsoleFunction( mSaturate, F32, ( F32 v ),,
    "Clamp the specified value between 0 and 1 (inclusive).\n"
    "@param v Input value."
    "@returns The specified value clamped between 0 and 1 (inclusive)."
    "@ingroup Math" )
{
   return mClampF( v, 0.0f, 1.0f );
}

DefineConsoleFunction( getMax, F32, ( F32 v1, F32 v2 ),,
    "Calculate the greater of two specified numbers.\n"
    "@param v1 Input value."
    "@param v2 Input value."
    "@returns The greater value of the two specified values."
    "@ingroup Math" )
{
   return getMax( v1, v2 );
}

DefineConsoleFunction( getMin, F32, ( F32 v1, F32 v2 ),,
    "Calculate the lesser of two specified numbers.\n"
    "@param v1 Input value."
    "@param v2 Input value."
    "@returns The lesser value of the two specified values."
    "@ingroup Math" )
{
   return getMin( v1, v2 );
}

DefineConsoleFunction( mLerp, F32, ( F32 v1, F32 v2, F32 time ),,
    "Calculate linearly interpolated value between two specified numbers using specified normalized time.\n"
    "@param v1 Interpolate From Input value."
    "@param v2 Interpolate To Input value."
    "@param time Normalized time used to interpolate values (0-1)."
    "@returns The interpolated value between the two specified values at normalized time t."
    "@ingroup Math" )
{
   return mLerp( v1, v2, time );
}

DefineConsoleFunction( mPi, F32, (),,
    "Return the value of PI (half-circle in radians).\n"
    "@returns The value of PI."
    "@ingroup Math" )
{
   return M_PI_F;
}

DefineConsoleFunction( m2Pi, F32, (),,
    "Return the value of 2*PI (full-circle in radians).\n"
    "@returns The value of 2*PI."
    "@ingroup Math" )
{
   return M_2PI_F;
}

DefineConsoleFunction( mIsPow2, bool, ( S32 v ),,
    "Returns whether the value is an exact power of two.\n"
    "@param v Input value."
    "@returns Whether the specified value is an exact power of two."
    "@ingroup Math" )
{
   return isPow2( v );
}


















































//---------------DNTC AUTO-GENERATED---------------//
#include <vector>

#include <string>

#include "core/strings/stringFunctions.h"

//---------------DO NOT MODIFY CODE BELOW----------//

extern "C" __declspec(dllexport) F32  __cdecl wle_fn_getMax(F32 v1, F32 v2)
{

{
  return (F32)( getMax( v1, v2 ));
};
}
extern "C" __declspec(dllexport) F32  __cdecl wle_fn_getMin(F32 v1, F32 v2)
{

{
  return (F32)( getMin( v1, v2 ));
};
}
extern "C" __declspec(dllexport) F32  __cdecl wle_fn_m2Pi()
{
{
  return (F32)( M_2PI_F);
};
}
extern "C" __declspec(dllexport) F32  __cdecl wle_fn_mAbs(F32 v)
{
{
  return (F32)( mFabs( v ));
};
}
extern "C" __declspec(dllexport) F32  __cdecl wle_fn_mAcos(F32 v)
{
{
  return (F32)( mAcos( v ));
};
}
extern "C" __declspec(dllexport) F32  __cdecl wle_fn_mAsin(F32 v)
{
{
  return (F32)( mAsin( v ));
};
}
extern "C" __declspec(dllexport) F32  __cdecl wle_fn_mAtan(F32 rise, F32 run)
{

{
  return (F32)( mAtan2( rise, run ));
};
}
extern "C" __declspec(dllexport) S32  __cdecl wle_fn_mCeil(F32 v)
{
{
  return (S32)( (S32)mCeil( v ));
};
}
extern "C" __declspec(dllexport) F32  __cdecl wle_fn_mClamp(F32 v, F32 min, F32 max)
{

{
  return (F32)( mClampF( v, min, max ));
};
}
extern "C" __declspec(dllexport) F32  __cdecl wle_fn_mCos(F32 v)
{
{
  return (F32)( mCos( v ));
};
}
extern "C" __declspec(dllexport) F32  __cdecl wle_fn_mDegToRad(F32 degrees)
{
{
  return (F32)( mDegToRad( degrees ));
};
}
extern "C" __declspec(dllexport) void  __cdecl wle_fn_mFloatLength(F32 v, U32 precision,  char* retval)
{
dSprintf(retval,16384,"");
const char* wle_returnObject;
{
   char fmtString[8] = "%.9f";
   if (precision >= 9)
      precision = 9;
   fmtString[2] = '0' + precision;
   static const U32 bufSize = 256;
   char * outBuffer = Con::getReturnBuffer(bufSize);
   dSprintf(outBuffer, bufSize, fmtString, v);
   {wle_returnObject =outBuffer;
if (!wle_returnObject) 
return;
dSprintf(retval,16384,"%s",wle_returnObject);
return;
}
}
}
extern "C" __declspec(dllexport) S32  __cdecl wle_fn_mFloor(F32 v)
{
{
  return (S32)( (S32)mFloor( v ));
};
}
extern "C" __declspec(dllexport) F32  __cdecl wle_fn_mFMod(F32 v, F32 d)
{

{
  return (F32)( mFmod( v, d ));
};
}
extern "C" __declspec(dllexport) S32  __cdecl wle_fn_mIsPow2(S32 v)
{
bool wle_returnObject;
{
   {wle_returnObject =isPow2( v );
return (S32)(wle_returnObject);}
}
}
extern "C" __declspec(dllexport) F32  __cdecl wle_fn_mLerp(F32 v1, F32 v2, F32 time)
{

{
  return (F32)( mLerp( v1, v2, time ));
};
}
extern "C" __declspec(dllexport) F32  __cdecl wle_fn_mLog(F32 v)
{
{
  return (F32)( mLog( v ));
};
}
extern "C" __declspec(dllexport) F32  __cdecl wle_fn_mPi()
{
{
  return (F32)( M_PI_F);
};
}
extern "C" __declspec(dllexport) F32  __cdecl wle_fn_mPow(F32 v, F32 p)
{

{
  return (F32)( mPow( v, p ));
};
}
extern "C" __declspec(dllexport) F32  __cdecl wle_fn_mRadToDeg(F32 radians)
{
{
  return (F32)( mRadToDeg( radians ));
};
}
extern "C" __declspec(dllexport) F32  __cdecl wle_fn_mRound(F32 v, S32 n)
{

{  
    if(n <= 0)
	{
       return (F32)( mRound(v));  
	}
    else  
	{
       return (F32)( mRound(v, n));  
	}
};
}
extern "C" __declspec(dllexport) F32  __cdecl wle_fn_mSaturate(F32 v)
{
{
  return (F32)( mClampF( v, 0.0f, 1.0f ));
};
}
extern "C" __declspec(dllexport) F32  __cdecl wle_fn_mSin(F32 v)
{
{
  return (F32)( mSin( v ));
};
}
extern "C" __declspec(dllexport) void  __cdecl wle_fn_mSolveCubic(F32 a, F32 b, F32 c, F32 d,  char* retval)
{
dSprintf(retval,16384,"");

const char* wle_returnObject;
{    
   F32 x[3];
   U32 sol = mSolveCubic( a, b, c, d, x );
   static const U32 bufSize = 256;
   char * retBuffer = Con::getReturnBuffer(bufSize);
   dSprintf(retBuffer, bufSize, "%d %g %g %g", sol, x[0], x[1], x[2]);
   {wle_returnObject =retBuffer;
if (!wle_returnObject) 
return;
dSprintf(retval,16384,"%s",wle_returnObject);
return;
}
}
}
extern "C" __declspec(dllexport) void  __cdecl wle_fn_mSolveQuadratic(F32 a, F32 b, F32 c,  char* retval)
{
dSprintf(retval,16384,"");

const char* wle_returnObject;
{
   F32 x[2];
   U32 sol = mSolveQuadratic( a, b, c, x );
   static const U32 bufSize = 256;
   char * retBuffer = Con::getReturnBuffer(bufSize);
   dSprintf(retBuffer, bufSize, "%d %g %g", sol, x[0], x[1]);
   {wle_returnObject =retBuffer;
if (!wle_returnObject) 
return;
dSprintf(retval,16384,"%s",wle_returnObject);
return;
}
}
}
extern "C" __declspec(dllexport) void  __cdecl wle_fn_mSolveQuartic(F32 a, F32 b, F32 c, F32 d, F32 e,  char* retval)
{
dSprintf(retval,16384,"");


const char* wle_returnObject;
{
   F32 x[4];
   static const U32 bufSize = 256;
   char * retBuffer = Con::getReturnBuffer(bufSize);
   U32 sol = mSolveQuartic(a, b, c, d, e, x);
   dSprintf(retBuffer, 256, "%d %g %g %g %g", sol, x[0], x[1], x[2], x[3]);
   {wle_returnObject =retBuffer;
if (!wle_returnObject) 
return;
dSprintf(retval,16384,"%s",wle_returnObject);
return;
}
}
}
extern "C" __declspec(dllexport) F32  __cdecl wle_fn_mSqrt(F32 v)
{
{
  return (F32)( mSqrt (v ));
};
}
extern "C" __declspec(dllexport) F32  __cdecl wle_fn_mTan(F32 v)
{
{
  return (F32)( mTan( v ));
};
}
//---------------END DNTC AUTO-GENERATED-----------//

