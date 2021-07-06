using System;
using UnityEngine;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class Pointer
{
    public static Vector2 Position => Camera.main.ScreenToWorldPoint(Input.mousePosition);

    public static T GetObjectOnPointer<T>()
    {
        var hits = Physics2D.RaycastAll(Position, Vector3.forward);
        if (hits.Length > 0)
        {
            T obj = hits.Select(x => x.transform.GetComponent<T>()).First();
            return obj;
        }
        return default;
    }
}
