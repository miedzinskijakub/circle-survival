using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Circleq { 
public abstract class Circles : MonoBehaviour
{
    [SerializeField] public float minTime = 2f;
    [SerializeField] public float maxTime = 4f;
     public float timeLeft;
     protected GameSession gameSession;

        private void Awake()
        {
             timeLeft = Random.Range(minTime, maxTime);
            gameSession = FindObjectOfType<GameSession>();
        }
        public virtual void DestroyByTime()
        {
            timeLeft -= Time.deltaTime;
            if (timeLeft <= 0)
            {
                OnTimeOut();
                Destroy(gameObject);
            }
        }
        protected virtual void OnTimeOut() { }

        public abstract void Logic();

        private void Update()
        {
            DestroyByTime();
            
        }
    }
}
