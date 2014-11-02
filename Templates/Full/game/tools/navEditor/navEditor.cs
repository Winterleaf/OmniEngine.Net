//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------

singleton GuiControlProfile(NavEditorProfile)
{
   canKeyFocus = true;
   opaque = true;
   fillColor = "192 192 192 192";
   category = "Editor";
};

singleton GuiControlProfile(GuiSimpleBorderProfile)
{
   opaque = false;   
   border = 1;   
   category = "Editor";
};
 