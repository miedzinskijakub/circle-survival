using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    [SerializeField] float minTime;
    [SerializeField] float maxTime;
    float timeLeft;

    GameSession gameSession;
    


    void Start()
    {
      
        timeLeft = Random.Range(minTime, maxTime);
        gameSession = FindObjectOfType<GameSession>();

      
    }

    void Update()
    {
        
        timeLeft -= Time.deltaTime;
        if(timeLeft < 0)
        {

            gameSession.GameOver();
            Destroy(gameObject);
        }
        
    }

   
}
