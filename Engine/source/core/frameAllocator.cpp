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

#include "core/frameAllocator.h"
#include "console/console.h"
#include "console/engineAPI.h"

U8*   FrameAllocator::smBuffer = NULL;
U32   FrameAllocator::smWaterMark = 0;
U32   FrameAllocator::smHighWaterMark = 0;

#ifdef TORQUE_DEBUG
U32   FrameAllocator::smMaxFrameAllocation = 0;
#endif

//ConsoleFunction(getMaxFrameAllocation, S32, 1,1, "getMaxFrameAllocation();")
DefineConsoleFunction( getMaxFrameAllocation, S32, (), , "getMaxFrameAllocation();" )
{
#ifdef TORQUE_DEBUG
   return FrameAllocator::getMaxFrameAllocation();
#else
	return 0;
#endif
}
//#endif


















































//---------------DNTC AUTO-GENERATED---------------//
#include <vector>

#include <string>

#include "core/strings/stringFunctions.h"

//---------------DO NOT MODIFY CODE BELOW----------//

extern "C" __declspec(dllexport) S32  __cdecl wle_fn_getMaxFrameAllocation()
{
{
#ifdef TORQUE_DEBUG
  return (S32)( FrameAllocator::getMaxFrameAllocation());
#else
	return 0;
#endif
};
}
//---------------END DNTC AUTO-GENERATED-----------//

