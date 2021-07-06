using UnityEngine;
using System.Collections;

public class ImpulseNode : Node
{
    public Vector2 direction;
    public float force;

    public override void Activate()
    {
        var body = bot.GetComponent<Rigidbody2D>();
        body?.AddForce(direction * force);
    }

    public override void Signal(Node source)
    {
        Activate();
    }
}

