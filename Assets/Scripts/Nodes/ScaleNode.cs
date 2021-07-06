using UnityEngine;
using System.Collections;
using DG.Tweening;

public class ScaleNode : Node
{
    public float scale;

    public override void Activate()
    {
        bot.transform.DOScale(scale, 0.7f).SetEase(Ease.OutBack);
    }

    public override void Signal(Node source)
    {
        Activate();
    }
}
