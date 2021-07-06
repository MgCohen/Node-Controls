using UnityEngine;
using System.Collections;

public class LoggerNode : Node
{
    public string message;

    public override void Activate()
    {
        Debug.Log(message);
    }

    public override void Signal(Node source)
    {
        Activate();
    }
}
