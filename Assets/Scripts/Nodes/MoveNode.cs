using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoveNode : Node
{

    [SerializeField] Vector2 direction;

    public override void Activate()
    {
        Move(direction);
    }

    public override void Signal(Node source)
    {
        Activate();
    }

    void Move(Vector3 dir)
    {
        bot.transform.DOMove(bot.transform.position + dir, 5f).SetSpeedBased();
    }
}
