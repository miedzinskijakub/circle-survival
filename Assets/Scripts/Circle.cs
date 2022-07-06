using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Circleq;

public class Circle : Circles, IDestroyable
{
   // [SerializeField] float minTime;
   // [SerializeField] float maxTime;
   // float timeLeft;

    void Start()
    {


       // SetTime();
      
    }

   // void Update()
    //{
      //  DestroyByTime();

   // }
    /*
    private void DestroyByTime()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            //gameSession.GameOver();
            Destroy(gameObject);
        }
    }*/

    private void DestroyByTap()
    {
        Destroy(gameObject);
    }

    public override void SetTime()
    {
        timeLeft = Random.Range(minTime, maxTime);

    }

    public void Interact()
    {
        DestroyByTap();
    }
}
