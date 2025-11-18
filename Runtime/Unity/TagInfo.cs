using UnityEngine;
using System;

namespace AprilTag {

//
// Tag pose structure for storing an estimated pose
//
public struct TagInfo
{
    public int ID { get; }
    public (double x, double y) Center { get; }
    public (double x, double y) Corner1 { get; }
    public (double x, double y) Corner2 { get; }
    public (double x, double y) Corner3 { get; }
    public (double x, double y) Corner4 { get; }

    public TagInfo(int id, ValueTuple<double, double> center, ValueTuple<double, double> corner1, ValueTuple<double, double> corner2, ValueTuple<double, double> corner3, ValueTuple<double, double> corner4)
    {
        ID = id;
        Center = center;
        Corner1 = corner1;
        Corner2 = corner2;
        Corner3 = corner3;
        Corner4 = corner4;
    }
}

} // namespace AprilTag
