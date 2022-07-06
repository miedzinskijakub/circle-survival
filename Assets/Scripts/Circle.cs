using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Circleq;

public class Circle : Circles, IDestroyable
{
    /*
     [SerializeField] float minTime;
    [SerializeField] float maxTime;

    void Update()
   {
     DestroyByTime();

    }
   public override void SetTime()
   {
       timeLeft = Random.Range(minTime, maxTime);

   }
   */
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
