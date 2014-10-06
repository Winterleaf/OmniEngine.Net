#ifdef TORQUE_WALKABOUT_EXTRAS_ENABLED
//-----------------------------------------------------------------------------
// Copyright (c) 2012 Daniel Buckmaster
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

#ifndef _OBJPOLYLIST_H_
#define _OBJPOLYLIST_H_

#include "collision/abstractPolyList.h"
#include "core/util/tVector.h"
//#include "math/mBox.h"

/// Represents polygons in the same manner as the .obj file format. Handy for
/// padding data to Recast, since it expects this data format. At the moment,
/// this class only accepts triangles.
/// @see AbstractPolyList
class ObjPolyList : public AbstractPolyList {
public:
   /// @name AbstractPolyList
   /// @{

   bool isEmpty() const;

   U32 addPoint(const Point3F &p);
   U32 addPlane(const PlaneF &plane);

   void begin(BaseMatInstance *material, U32 surfaceKey);

   void plane(U32 v1, U32 v2, U32 v3);
   void plane(const PlaneF& p);
   void plane(const U32 index);

   void vertex(U32 vi);

   void end();

   /// @}

   /// @name Data interface
   /// @{

   U32 getVertCount() const;
   const F32 *getVerts() const;

   U32 getTriCount() const;
   const S32 *getTris() const;

   //static void parse(ObjPolyList &list, Box3F box, U32 mask);

   void clear();

   void renderWire() const;

   /// @}

   /// Default constructor.
   ObjPolyList();
   /// Default destructor.
   ~ObjPolyList();

protected:
   /// Number of vertices defined.
   U32 nverts;
   /// Array of vertex coordinates. Size nverts*3
   F32 *verts;
   /// Size of vertex array.
   U32 vertcap;

   /// Number of triangles defined.
   U32 ntris;
   /// Array of triangle vertex indices. Size ntris*3
   S32 *tris;
   /// Size of triangle array.
   U32 tricap;

   /// Index of vertex we're adding to the current triangle.
   U8 vidx;

   /// Store a list of planes - not actually used.
   Vector<PlaneF> planes;
   /// Another inherited utility function.
   const PlaneF& getIndexedPlane(const U32 index) { return planes[index]; }

private:
};

#endif

#endif // TORQUE_WALKABOUT_EXTRAS_ENABLED
