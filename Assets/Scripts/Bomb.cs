using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
  
    float timeLeft;
    
    void Start()
    {
       
        timeLeft = 3f;

  
    }

    void Update()
    {

        timeLeft -= Time.deltaTime;

        if(timeLeft < 0)
        {
            Destroy(gameObject);
        }
        
    }

}
