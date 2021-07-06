using UnityEngine;
using System.Collections;

public class KeyTriggerNode : Node, ITick
{

    public KeyCode key;

    public override void Activate()
    {
        used = true;
        var connectedNodes = currentSlot.GetConnectedNodes();
        Debug.Log("Trigger");
        foreach (var node in connectedNodes)
        {
            if (node.CheckNodeReady())
                node.Signal(this);
        }
    }

    public override void Signal(Node source)
    {
        //do nothing
    }

    public void Tick()
    {
        if (Input.GetKeyDown(key))
        {
            Activate();
        }
    }
}
