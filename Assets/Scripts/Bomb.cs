using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Circleq;

public class Bomb : Circles, IDestroyable
{
    public void Interact()
    {
        Logic();
    }

    public override void Logic()
    {
        gameSession.GameOver();
    }

}
