using System;
using UnityEngine;

public static class Helper
{

    public static Vector2Int RoundVector2(this Vector2 vector)
    {
        var x = Mathf.RoundToInt(vector.x);
        var y = Mathf.RoundToInt(vector.y);
        return new Vector2Int(x, y);
    }

    public static Vector2Int RoundVector2(this Vector3 vector)
    {
        var x = Mathf.RoundToInt(vector.x);
        var y = Mathf.RoundToInt(vector.y);
        return new Vector2Int(x, y);
    }
}
