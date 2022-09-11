using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FruitBowl.Orange
{
    public static class MathUtils
    {
        public static Vector2 LineLineIntersection((Vector3,Vector3) segmentA, (Vector3, Vector3) segmentB, out float t0, out float s0)
        {
            // FIXME: XY only for now
            Vector2 v = segmentA.Item1 - segmentA.Item2;
            Vector2 u = segmentB.Item1 - segmentB.Item2;
            Vector2 w = segmentA.Item2 - segmentB.Item2;
            Vector2 xv = new Vector2(v.y, -v.x);
            Vector2 xu = new Vector2(u.y, -u.x);

            float dv = Vector2.Dot(u, xv);
            float du = Vector2.Dot(v, xu);

            if (dv != 0)
            {
                s0 = Vector2.Dot(w, xv) / dv;
                t0 = -Vector2.Dot(w, xu) / du;
                return Vector2.Lerp(segmentB.Item2, segmentB.Item1, s0);
            }
            else
            {
                s0 = float.NegativeInfinity;
                t0 = float.NegativeInfinity;
                return Vector2.positiveInfinity;
            }
        }
    }
}
