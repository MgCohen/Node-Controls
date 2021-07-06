using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Directions
{
    public readonly static List<Vector2Int> directions = new List<Vector2Int>()
    {
        Vector2Int.up,
        Vector2Int.down,
        Vector2Int.left,
        Vector2Int.right,
    };

}
