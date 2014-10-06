#include "console/engineAPI.h"
#include "platform/platform.h"
#include "core/util/path.h"
#include "console/engineapi.h"
#include "math/mPoint3.h"
#include "console/consoleInternal.h"
#include "console/ast.h"
#include "math/mTransform.h"
#include "core/color.h"
#include "gui/core/guiTypes.h"

DefineConsoleFunction( dnt_testcase_1, StringTableEntry, ( const char* chr ),,
	"Return the integer character code value corresponding to the first character in the given string.\n"
)
{
	return chr;
}

DefineConsoleFunction( dnt_testcase_2, AngAxisF, ( AngAxisF chr ),,
	"Return the integer character code value corresponding to the first character in the given string.\n"
)
{
	return chr;
}

DefineConsoleFunction( dnt_testcase_3, Box3F, ( Box3F chr ),,
	"Return the integer character code value corresponding to the first character in the given string.\n"
)
{
	return chr;
}

DefineConsoleFunction( dnt_testcase_4, ColorF, ( ColorF chr ),,
	"Return the integer character code value corresponding to the first character in the given string.\n"
)
{
	return chr;
}

DefineConsoleFunction( dnt_testcase_5, ColorI, ( ColorI chr ),,
	"Return the integer character code value corresponding to the first character in the given string.\n"
)
{
	return chr;
}

DefineConsoleFunction( dnt_testcase_6, EaseF, ( EaseF chr ),,
	"Return the integer character code value corresponding to the first character in the given string.\n"
)
{
	return chr;
}

DefineConsoleFunction( dnt_testcase_7, Point2F, ( Point2F chr ),,
	"Return the integer character code value corresponding to the first character in the given string.\n"
)
{
	return chr;
}

DefineConsoleFunction( dnt_testcase_8, Point2I, ( Point2I chr ),,
	"Return the integer character code value corresponding to the first character in the given string.\n"
)
{
	return chr;
}

DefineConsoleFunction( dnt_testcase_9, Point3F, ( Point3F chr ),,
	"Return the integer character code value corresponding to the first character in the given string.\n"
)
{
	return chr;
}

DefineConsoleFunction( dnt_testcase_10, Point4F, ( Point4F chr ),,
	"Return the integer character code value corresponding to the first character in the given string.\n"
)
{
	return chr;
}


DefineConsoleFunction( dnt_testcase_12, RectF, ( RectF chr ),,
	"Return the integer character code value corresponding to the first character in the given string.\n"
)
{
	return chr;
}

DefineConsoleFunction( dnt_testcase_13, RectI, ( RectI chr ),,
	"Return the integer character code value corresponding to the first character in the given string.\n"
)
{
	return chr;
}

DefineConsoleFunction( dnt_testcase_14, RectSpacingI, ( RectSpacingI chr ),,
	"Return the integer character code value corresponding to the first character in the given string.\n"
)
{
	return chr;
}

DefineConsoleFunction( dnt_testcase_15, TransformF, ( TransformF chr ),,
	"Return the integer character code value corresponding to the first character in the given string.\n"
)
{
	return chr;
}


















































//---------------DNTC AUTO-GENERATED---------------//
#include <vector>

#include <string>

#include "core/strings/stringFunctions.h"

//---------------DO NOT MODIFY CODE BELOW----------//

extern "C" __declspec(dllexport) void  __cdecl wle_fn_dnt_testcase_1(char * x__chr,  char* retval)
{
dSprintf(retval,16384,"");
const char* chr = (const char*)x__chr;
const char* wle_returnObject;
{
	{wle_returnObject =chr;
if (!wle_returnObject) 
return;
dSprintf(retval,16384,"%s",wle_returnObject);
return;
}
}
}
extern "C" __declspec(dllexport) void  __cdecl wle_fn_dnt_testcase_10(char * x__chr,  char* retval)
{
dSprintf(retval,1024,"");
Point4F chr = Point4F();
sscanf(x__chr,"%g %g %g %g",&chr.x,&chr.y,&chr.z,&chr.w);
Point4F wle_returnObject;
{
	{wle_returnObject =chr;
dSprintf(retval,1024,"%g %g %g %g ",wle_returnObject.x,wle_returnObject.y,wle_returnObject.z,wle_returnObject.w);
return;
}
}
}
extern "C" __declspec(dllexport) void  __cdecl wle_fn_dnt_testcase_12(char * x__chr,  char* retval)
{
dSprintf(retval,1024,"");
RectF chr = RectF();
sscanf(x__chr,"%g %g %g %g",&chr.point.x,&chr.point.y,&chr.extent.x,&chr.extent.y);
RectF wle_returnObject;
{
	{wle_returnObject =chr;
dSprintf(retval,1024,"%g %g %g %g ",wle_returnObject.point.x,wle_returnObject.point.y,wle_returnObject.extent.x,wle_returnObject.extent.y);
return;
}
}
}
extern "C" __declspec(dllexport) void  __cdecl wle_fn_dnt_testcase_13(char * x__chr,  char* retval)
{
dSprintf(retval,1024,"");
RectI chr = RectI();
sscanf(x__chr,"%d %d %d %d",&chr.point.x,&chr.point.y,&chr.extent.x,&chr.extent.y);
RectI wle_returnObject;
{
	{wle_returnObject =chr;
dSprintf(retval,1024,"%d %d %d %d ",wle_returnObject.point.x,wle_returnObject.point.y,wle_returnObject.extent.x,wle_returnObject.extent.y);
return;
}
}
}
extern "C" __declspec(dllexport) void  __cdecl wle_fn_dnt_testcase_14(char * x__chr,  char* retval)
{
dSprintf(retval,1024,"");
RectSpacingI chr = RectSpacingI();
sscanf(x__chr, "%i %i %i %i", &chr.top, &chr.bottom, &chr.left, &chr.right);
RectSpacingI wle_returnObject;
{
	{wle_returnObject =chr;
dSprintf(retval,1024,"%i %i %i %i ",wle_returnObject.top,wle_returnObject.bottom,wle_returnObject.left,wle_returnObject.right);
return;
}
}
}
extern "C" __declspec(dllexport) void  __cdecl wle_fn_dnt_testcase_15(char * x__chr,  char* retval)
{
dSprintf(retval,1024,"");
TransformF chr = TransformF();
sscanf( x__chr,"%f %f %f %f %f %f %f", &chr.mPosition.x, &chr.mPosition.y, &chr.mPosition.z, &chr.mOrientation.axis.x, &chr.mOrientation.axis.y, &chr.mOrientation.axis.z, &chr.mOrientation.angle);
TransformF wle_returnObject;
{
	{wle_returnObject =chr;
dSprintf(retval,1024,"%f %f %f %f %f %f %f ",wle_returnObject.mPosition.x,wle_returnObject.mPosition.y,wle_returnObject.mPosition.z,wle_returnObject.mOrientation.axis.x,wle_returnObject.mOrientation.axis.y,wle_returnObject.mOrientation.axis.z,wle_returnObject.mOrientation.angle);
return;
}
}
}
extern "C" __declspec(dllexport) void  __cdecl wle_fn_dnt_testcase_2(char * x__chr,  char* retval)
{
dSprintf(retval,1024,"");
AngAxisF chr = AngAxisF();
sscanf(x__chr,"%f %f %f %f",&chr.axis.x,&chr.axis.y,&chr.axis.z,&chr.angle);
AngAxisF wle_returnObject;
{
	{wle_returnObject =chr;
dSprintf(retval,1024,"%f %f %f %f ",wle_returnObject.axis.x,wle_returnObject.axis.y,wle_returnObject.axis.z,wle_returnObject.angle);
return;
}
}
}
extern "C" __declspec(dllexport) void  __cdecl wle_fn_dnt_testcase_3(char * x__chr,  char* retval)
{
dSprintf(retval,1024,"");
Box3F chr = Box3F();
sscanf(x__chr,"%f %f %f %f %f %f",&chr.minExtents.x,&chr.minExtents.y,&chr.minExtents.z,&chr.maxExtents.x,&chr.maxExtents.y,&chr.maxExtents.z);
Box3F wle_returnObject;
{
	{wle_returnObject =chr;
dSprintf(retval,1024,"%f %f %f %f %f %f ",wle_returnObject.minExtents.x,wle_returnObject.minExtents.y,wle_returnObject.minExtents.z,wle_returnObject.maxExtents.x,wle_returnObject.maxExtents.y,wle_returnObject.maxExtents.z);
return;
}
}
}
extern "C" __declspec(dllexport) void  __cdecl wle_fn_dnt_testcase_4(char * x__chr,  char* retval)
{
dSprintf(retval,1024,"");
ColorF chr = ColorF();
sscanf(x__chr,"%f %f %f %f",&chr.red,&chr.green,&chr.blue,&chr.alpha);
ColorF wle_returnObject;
{
	{wle_returnObject =chr;
dSprintf(retval,1024,"%f %f %f %f ",wle_returnObject.red,wle_returnObject.green,wle_returnObject.blue,wle_returnObject.alpha);
return;
}
}
}
extern "C" __declspec(dllexport) void  __cdecl wle_fn_dnt_testcase_5(char * x__chr,  char* retval)
{
dSprintf(retval,1024,"");
ColorI chr = ColorI();
{
int r,g,b,a;
sscanf(x__chr,"%d %d %d %d ",&r,&g,&b,&a);
chr.red =(unsigned short)r;
chr.green=(unsigned short)g;
chr.blue=(unsigned short)b;
chr.alpha=(unsigned short)a;
}
ColorI wle_returnObject;
{
	{wle_returnObject =chr;
dSprintf(retval,1024,"%d %d %d %d ",(int)wle_returnObject.red,(int)wle_returnObject.green,(int)wle_returnObject.blue,(int)wle_returnObject.alpha);
return;
}
}
}
extern "C" __declspec(dllexport) void  __cdecl wle_fn_dnt_testcase_6(char * x__chr,  char* retval)
{
dSprintf(retval,1024,"");
EaseF chr = EaseF();
sscanf(x__chr,"%d %d %f %f",&chr.dir,&chr.type,&chr.param[0],&chr.param[1]);
EaseF wle_returnObject;
{
	{wle_returnObject =chr;
dSprintf(retval,1024,"%d %d %g %g ",wle_returnObject.dir,wle_returnObject.type,wle_returnObject.param[0],wle_returnObject.param[1]);
return;
}
}
}
extern "C" __declspec(dllexport) void  __cdecl wle_fn_dnt_testcase_7(char * x__chr,  char* retval)
{
dSprintf(retval,1024,"");
Point2F chr = Point2F();
sscanf(x__chr,"%f %f",&chr.x,&chr.y);
Point2F wle_returnObject;
{
	{wle_returnObject =chr;
dSprintf(retval,1024,"%f %f ",wle_returnObject.x,wle_returnObject.y);
return;
}
}
}
extern "C" __declspec(dllexport) void  __cdecl wle_fn_dnt_testcase_8(char * x__chr,  char* retval)
{
dSprintf(retval,1024,"");
Point2I chr = Point2I();
sscanf(x__chr,"%i %i",&chr.x,&chr.y);
Point2I wle_returnObject;
{
	{wle_returnObject =chr;
dSprintf(retval,1024,"%i %i ",wle_returnObject.x,wle_returnObject.y);
return;
}
}
}
extern "C" __declspec(dllexport) void  __cdecl wle_fn_dnt_testcase_9(char * x__chr,  char* retval)
{
dSprintf(retval,1024,"");
Point3F chr = Point3F();
sscanf(x__chr,"%f %f %f",&chr.x,&chr.y,&chr.z);
Point3F wle_returnObject;
{
	{wle_returnObject =chr;
dSprintf(retval,1024,"%f %f %f ",wle_returnObject.x,wle_returnObject.y,wle_returnObject.z);
return;
}
}
}
//---------------END DNTC AUTO-GENERATED-----------//

