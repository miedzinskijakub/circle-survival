using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Circleq { 
public abstract class Circles : MonoBehaviour
{
    [SerializeField] public float minTime = 3f;
    [SerializeField] public float maxTime = 4f;
        public float timeLeft;
    GameSession gameSession;

        private void Awake()
        {
             timeLeft = Random.Range(minTime, maxTime);
            //timeLeft = 999999f;
            gameSession = FindObjectOfType<GameSession>();
        }

        public abstract void SetTime();
        public void DestroyByTime()
        {
            timeLeft -= Time.deltaTime;
            if (timeLeft <= 0)
            {
                //gameSession.GameOver();
                Destroy(gameObject);
            }
        }
     

        private void Update()
        {
            DestroyByTime();
           // Debug.Log("timeleft: " + timeLeft);
           // Debug.Log(gameObject.name + " : " + gameObject.transform.position);
            
        }
    }
}
