using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Node : MonoBehaviour
{
    public Slot currentSlot;
    [HideInInspector]public Bot bot;

    public bool used;
    public bool reusable;

    public bool CheckNodeReady()
    {
        return (used && !reusable) ? false : true;
    }

    public abstract void Activate();

    public abstract void Signal(Node source);

}
