using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static partial class Vector3Extension
{
    /// <summary>
    /// 计算目标点坐标
    /// </summary>
    /// <param name="self">角度</param>
    /// <param name="angle">起点</param>
    /// <param name="distance">距离</param>
    /// <returns>终点坐标</returns>
    public static Vector3 TargetPoint(this Vector3 self, Vector3 angle, float distance)
    {
        var rotation = Quaternion.Euler(angle);
        var forward = rotation * Vector3.forward;
        var endPoint = self + forward * distance;
        return endPoint;
    }

    /// <summary>
    /// 计算目标点角度
    /// </summary>
    /// <param name="start"></param>
    /// <param name="end"></param>
    /// <returns></returns>
    public static float TargetAngle(this Vector3 start, Vector3 end)
    {
        Vector2 angleStart = new Vector3(start.x + Vector2.Distance(start, end), start.y) - start;
        Vector2 angleEnd = end - start;
        if (end.y < start.y)
        {
            return 180 - Vector2.Angle(angleStart, angleEnd) + 180;
        }
        else
            return Vector2.Angle(angleStart, angleEnd);
    }
}