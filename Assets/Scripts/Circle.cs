using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Circleq;

public class Circle : Circles, IDestroyable
{
    protected override void OnTimeOut()
    {
        gameSession.GameOver();
    }

    public override void Logic()
    {
        Destroy(gameObject);
    }

    public void Interact()
    {
        Logic();
    }
}
