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

//-----------------------------------------------------------------------------
// Ray to triangle intersection test code originally by Tomas Akenine-Möller
// and Ben Trumbore.
// http://www.cs.lth.se/home/Tomas_Akenine_Moller/code/
// Ported to TGE by DAW, 2005-7-15
//-----------------------------------------------------------------------------

#include "util/triRayCheck.h"
#include "math/mPlane.h"

#define EPSILON 0.000001
#define CROSS(dest,v1,v2) \
          dest[0]=v1[1]*v2[2]-v1[2]*v2[1]; \
          dest[1]=v1[2]*v2[0]-v1[0]*v2[2]; \
          dest[2]=v1[0]*v2[1]-v1[1]*v2[0];
#define DOT(v1,v2) (v1[0]*v2[0]+v1[1]*v2[1]+v1[2]*v2[2])
#define SUB(dest,v1,v2) \
          dest[0]=v1[0]-v2[0]; \
          dest[1]=v1[1]-v2[1]; \
          dest[2]=v1[2]-v2[2]; 

bool intersect_triangle(Point3F orig, Point3F dir,
                   Point3F vert0, Point3F vert1, Point3F vert2,
                   F32& t, F32& u, F32& v)
{
   Point3F edge1, edge2, tvec, pvec, qvec;
   F32 det,inv_det;

   /* find vectors for two edges sharing vert0 */
   edge1.x = vert1.x - vert0.x;
   edge1.y = vert1.y - vert0.y;
   edge1.z = vert1.z - vert0.z;
   edge2.x = vert2.x - vert0.x;
   edge2.y = vert2.y - vert0.y;
   edge2.z = vert2.z - vert0.z;

   /* begin calculating determinant - also used to calculate U parameter */
   //CROSS(pvec, dir, edge2);
   mCross(dir, edge2, &pvec);

   /* if determinant is near zero, ray lies in plane of triangle */
   //det = DOT(edge1, pvec);
   det = mDot(edge1, pvec);

#ifdef TEST_CULL           /* define TEST_CULL if culling is desired */
   if (det < EPSILON)
      return 0;

   /* calculate distance from vert0 to ray origin */
   SUB(tvec, orig, vert0);

   /* calculate U parameter and test bounds */
   *u = DOT(tvec, pvec);
   if (*u < 0.0 || *u > det)
      return 0;

   /* prepare to test V parameter */
   CROSS(qvec, tvec, edge1);

    /* calculate V parameter and test bounds */
   *v = DOT(dir, qvec);
   if (*v < 0.0 || *u + *v > det)
      return 0;

   /* calculate t, scale parameters, ray intersects triangle */
   *t = DOT(edge2, qvec);
   inv_det = 1.0 / det;
   *t *= inv_det;
   *u *= inv_det;
   *v *= inv_det;
#else                    /* the non-culling branch */
   if (det > -EPSILON && det < EPSILON)
     return false;
   inv_det = 1.0 / det;

   /* calculate distance from vert0 to ray origin */
   //SUB(tvec, orig, vert0);
   tvec.x = orig.x - vert0.x;
   tvec.y = orig.y - vert0.y;
   tvec.z = orig.z - vert0.z;

   /* calculate U parameter and test bounds */
//   *u = DOT(tvec, pvec) * inv_det;
   u = mDot(tvec, pvec) * inv_det;
   if (u < 0.0 || u > 1.0)
     return false;

   /* prepare to test V parameter */
   //CROSS(qvec, tvec, edge1);
   mCross(tvec, edge1, &qvec);

   /* calculate V parameter and test bounds */
//   *v = DOT(dir, qvec) * inv_det;
   v = mDot(dir, qvec) * inv_det;
   if (v < 0.0 || u + v > 1.0)
     return false;

   /* calculate t, ray intersects triangle */
//   *t = DOT(edge2, qvec) * inv_det;
   t = mDot(edge2, qvec) * inv_det;
#endif
   return true;
}

//*** Taken from TSE, and based on the above
bool castRayTriangle(Point3F orig, Point3F dir,
   Point3F vert0, Point3F vert1, Point3F vert2,
   F32 &t, Point2F &bary)
{
   Point3F tvec, qvec;

   // Find vectors for two edges sharing vert0
   const Point3F edge1 = vert1 - vert0;
   const Point3F edge2 = vert2 - vert0;

   // Begin calculating determinant - also used to calculate U parameter.
   const Point3F pvec = mCross(dir, edge2);

   // If determinant is near zero, ray lies in plane of triangle.
   const F32 det = mDot(edge1, pvec);

   if (det > 0.00001)
   {
      // calculate distance from vert0 to ray origin
      tvec = orig - vert0;

      // calculate U parameter and test bounds
      bary.x = mDot(tvec, pvec); // bary.x is really bary.u...
      if (bary.x < 0.0 || bary.x > det)
         return false;

      // prepare to test V parameter
      qvec = mCross(tvec, edge1);

      // calculate V parameter and test bounds
      bary.y = mDot(dir, qvec); // bary.y is really bary.v
      if (bary.y < 0.0 || (bary.x + bary.y) > det)
         return false;

   }
   else if(det < -0.00001)
   {
      // calculate distance from vert0 to ray origin
      tvec = orig - vert0;

      // calculate U parameter and test bounds
      bary.x = mDot(tvec, pvec);
      if (bary.x > 0.0 || bary.x < det)
         return false;

      // prepare to test V parameter
      qvec = mCross(tvec, edge1);

      // calculate V parameter and test bounds
      bary.y = mDot(dir, qvec);
      if (bary.y > 0.0 || (bary.x + bary.y) < det)
         return false;
   }
   else 
      return false;  // ray is parallel to the plane of the triangle.

   const F32 inv_det = 1.0 / det;

   // calculate t, ray intersects triangle
   t = mDot(edge2, qvec) * inv_det;
   bary *= inv_det;
   
   //AssertFatal((t >= 0.f && t <=1.f), "AtlasGeomTracer::castRayTriangle - invalid t!");

   // Hack, check the math here!
   return (t >= 0.f && t <=1.f);
}

bool castRayTriangle(const Point3D &orig, const Point3D &dir,
   const Point3D &vert0, const Point3D &vert1, const Point3D &vert2)
{
   F64 t;
   Point2D bary;
   Point3D tvec, qvec;

   // Find vectors for two edges sharing vert0
   const Point3D edge1 = vert1 - vert0;
   const Point3D edge2 = vert2 - vert0;

   // Begin calculating determinant - also used to calculate U parameter.
   Point3D pvec;
   mCross(dir, edge2, &pvec);

   // If determinant is near zero, ray lies in plane of triangle.
   const F64 det = mDot(edge1, pvec);

   if (det > 0.00001)
   {
      // calculate distance from vert0 to ray origin
      tvec = orig - vert0;

      // calculate U parameter and test bounds
      bary.x = mDot(tvec, pvec); // bary.x is really bary.u...
      if (bary.x < 0.0 || bary.x > det)
         return false;

      // prepare to test V parameter
      mCross(tvec, edge1, &qvec);

      // calculate V parameter and test bounds
      bary.y = mDot(dir, qvec); // bary.y is really bary.v
      if (bary.y < 0.0 || (bary.x + bary.y) > det)
         return false;

   }
   else if(det < -0.00001)
   {
      // calculate distance from vert0 to ray origin
      tvec = orig - vert0;

      // calculate U parameter and test bounds
      bary.x = mDot(tvec, pvec);
      if (bary.x > 0.0 || bary.x < det)
         return false;

      // prepare to test V parameter
      mCross(tvec, edge1, &qvec);

      // calculate V parameter and test bounds
      bary.y = mDot(dir, qvec);
      if (bary.y > 0.0 || (bary.x + bary.y) < det)
         return false;
   }
   else 
      return false;  // ray is parallel to the plane of the triangle.

   const F32 inv_det = 1.0 / det;

   // calculate t, ray intersects triangle
   t = mDot(edge2, qvec) * inv_det;
   bary *= inv_det;
   
   //AssertFatal((t >= 0.f && t <=1.f), "AtlasGeomTracer::castRayTriangle - invalid t!");

   // Hack, check the math here!
   return (t >= 0.f && t <=1.f);
}
//WLE - NEED INFO
bool castRayBrush(const Point3F &start, const Point3F &end,
				  PlaneF *planes, U32 planeCount)
{
   //   F32 startTime = -0.01f;
   F32 startNum = -0.01f;
   F32 startDen =  1.00f;
   //   F32 endTime   = 1.01f;
   F32 endNum = 1.01f;
   F32 endDen = 1.00f;

   S32 curPlane = 0;
//   U32 curMaterial = 0;
   bool found = false;

   bool tmpFound;
   S32 tmpPlane;
   F32 sgn = -1.0f;
   F32 * pnum = &startNum;
   F32 * pden = &startDen;
   S32 * pplane = &curPlane;
   bool * pfound = &found;

   for (S32 i=0; i<planeCount; i++)
   {
      // if start & end outside, no collision
      // if start & end inside, continue
      // if start outside, end inside, or visa versa, find intersection of line with plane
      //    then update intersection of line with hull (using startTime and endTime)
      F32 dot1 = mDot(planes[i],start) + planes[i].d;
      F32 dot2 = mDot(planes[i],end) + planes[i].d;
      if (dot1*dot2>0.0f)
      {
         // same side of the plane...which side -- dot==0 considered inside
         if (dot1>0.0f)
            // start and end outside of this plane, no collision
            return false;
         // start and end inside plane, continue
         continue;
      }

      AssertFatal(dot1/(dot1-dot2)>=0.0f && dot1/(dot1-dot2)<=1.0f,"TSMesh::castRay (1)");

      // find intersection (time) with this plane...
      // F32 time = dot1 / (dot1-dot2);
      F32 num = mFabs(dot1);
      F32 den = mFabs(dot1-dot2);

      if (sgn*dot1>=0)
      {
         sgn *= -1.0f;
         pnum = (F32*) ((dsize_t)pnum ^ (dsize_t)&endNum ^ (dsize_t)&startNum);
         pden = (F32*) ((dsize_t)pden ^ (dsize_t)&endDen ^ (dsize_t)&startDen);
         pplane = (S32*) ((dsize_t)pplane ^ (dsize_t)&tmpPlane ^ (dsize_t)&curPlane);
         pfound = (bool*) ((dsize_t)pfound ^ (dsize_t)&tmpFound ^ (dsize_t)&found);
      }
      bool noCollision = num*endDen*sgn<endNum*den*sgn && num*startDen*sgn<startNum*den*sgn;
      if (num * *pden * sgn < *pnum * den * sgn && !noCollision)
      {
         *pnum = num;
         *pden = den;
         *pplane = i;
         *pfound = true;
      }
      else if (noCollision)
         return false;
   }

   return found;
}
