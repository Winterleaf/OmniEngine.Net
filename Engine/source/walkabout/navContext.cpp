//-----------------------------------------------------------------------------
// Walkabout Navigation Toolkit
// Copyright (c) 2012 Daniel Buckmaster
// Permission is NOT granted to freely distribute the contents of this file.
//-----------------------------------------------------------------------------

#include "navContext.h"
#include "console/sim.h"

void NavContext::doResetLog()
{
}

void NavContext::log(const rcLogCategory category, const String &msg)
{
   doLog(category, msg.c_str(), msg.length());
}

void NavContext::doLog(const rcLogCategory category, const char* msg, const int len)
{
   if(category == RC_LOG_ERROR)
      Con::errorf(msg);
   else
      Con::printf(msg);
}

void NavContext::doResetTimers()
{
   for(U32 i = 0; i < RC_MAX_TIMERS; i++)
   {
      mTimers[i][0] = -1;
      mTimers[i][1] = -1;
   }
}

void NavContext::doStartTimer(const rcTimerLabel label)
{
   // Store starting time.
   mTimers[label][0] = Platform::getRealMilliseconds();
}

void NavContext::doStopTimer(const rcTimerLabel label)
{
   // Compute final time based on starting time.
   mTimers[label][1] = Platform::getRealMilliseconds() - mTimers[label][0];
}

int NavContext::doGetAccumulatedTime(const rcTimerLabel label) const
{
   return mTimers[label][1] == -1
      ? Platform::getRealMilliseconds() - mTimers[label][0]
      : mTimers[label][1];
}
