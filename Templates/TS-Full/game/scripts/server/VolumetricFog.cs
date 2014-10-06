//-----------------------------------------------------------------------------
// Copyright (c) 2014 R.G.S. - Richards Game Studio, the Netherlands
//					  http://www.richardsgamestudio.com/
//
// If you find this code useful or you are feeling particularly generous I
// would ask that you please go to http://www.richardsgamestudio.com/ then
// choose Donations from the menu on the left side and make a donation to
// Richards Game Studio. It will be highly appreciated.
//
// The MIT License:
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

function VolumetricFog::onEnterFog(%this,%obj)
{
   // This method is called whenever the control object (Camera or Player)
   // %obj enters the fog area.
   
   // echo("Control Object " @ %obj @ " enters fog " @ %this);
}

function VolumetricFog::onLeaveFog(%this,%obj)
{
   // This method is called whenever the control object (Camera or Player)
   // %obj leaves the fog area.
   
   // echo("Control Object " @ %obj @ " left fog " @ %this);
}

function VolumetricFog::Dissolve(%this,%speed)
{
   // This method dissolves the fog at speed milliseconds
   
   if (%this.FogDensity > 0)
   {
      %this.setFogDensity(%this.FogDensity - 0.01);
      %this.schedule(%speed,Dissolve,%speed);
   }
}

function VolumetricFog::Thicken(%this,%speed, %end_density)
{
   // This method thickens the fog at speed milliseconds to a density of %end_density
   
   if (%this.FogDensity + 0.01 < %end_density)
   {
      %this.setFogDensity(%this.FogDensity + 0.01);
      %this.schedule(%speed,Thicken,%speed, %end_density);
   }
   else
      %this.setFogDensity(%end_density);
}
