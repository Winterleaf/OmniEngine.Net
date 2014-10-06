//-----------------------------------------------------------------------------
// Walkabout Navigation Toolkit
// Copyright (c) 2012 Daniel Buckmaster
// Permission is NOT granted to freely distribute the contents of this file.
//-----------------------------------------------------------------------------

#ifndef _NAV_CONTEXT_H_
#define _NAV_CONTEXT_H_

#include "torqueRecast.h"
#include <Recast.h>

/// @brief Implements the rcContext interface in Torque.
class NavContext: public rcContext {
public:
   /// Default constructor.
   NavContext() : rcContext(true) { doResetTimers(); }

   void log(const rcLogCategory category, const String &msg);

protected:
   /// Clears all log entries.
   virtual void doResetLog();

   /// Logs a message.
   /// @param[in] category The category of the message.
   /// @param[in] msg      The formatted message.
   /// @param[in] len      The length of the formatted message.
   virtual void doLog(const rcLogCategory category, const char* msg, const int len);

   /// Clears all timers. (Resets all to unused.)
   virtual void doResetTimers();

   /// Starts the specified performance timer.
   /// @param[in] label The category of timer.
   virtual void doStartTimer(const rcTimerLabel label);

   /// Stops the specified performance timer.
   /// @param[in] label The category of the timer.
   virtual void doStopTimer(const rcTimerLabel label);

   /// Returns the total accumulated time of the specified performance timer.
   /// @param[in] label The category of the timer.
   /// @return The accumulated time of the timer, or -1 if timers are disabled or the timer has never been started.
   virtual int doGetAccumulatedTime(const rcTimerLabel label) const;

private:
   /// Store start time and final time for each timer.
   S32 mTimers[RC_MAX_TIMERS][2];
};

#endif
