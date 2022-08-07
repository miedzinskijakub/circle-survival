using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Circleq
{
    public abstract class Circles : MonoBehaviour
    {
        [SerializeField]
        public float minTime = 2f;

        [SerializeField]
        public float maxTime = 4f;

        public float timeLeft;
        private float time;
        private bool isScaling = false;
        protected GameSession gameSession;

        private void Awake()
        {
            timeLeft = Random.Range(minTime, maxTime);
            time = timeLeft;
            gameSession = FindObjectOfType<GameSession>();
        }

        private void Start()
        {
            StartCoroutine(ScaleOverTime(timeLeft));
        }

        #region AllCirclesLogic
        public virtual void ChangeSizeByTime(float timeLeft)
        {
            Vector3 originalScale = gameObject.transform.localScale;
            Vector3 destinationScale = new Vector3(.3f, .3f, 1f);

            float currentTime = 0.0f;

            if (currentTime < time)
            {
                gameObject.transform.localScale = Vector3.Lerp(
                    originalScale,
                    destinationScale,
                    currentTime * Time.deltaTime / timeLeft
                );
                currentTime += Time.deltaTime;
            }
        }

        IEnumerator ScaleOverTime(float duration)
        {
            if (isScaling)
            {
                yield break;
            }
            isScaling = true;

            float counter = 0;

            Vector3 originalScale = gameObject.transform.localScale;
            Vector3 destinationScale = new Vector3(.3f, .3f, 1f);

            while (counter < duration)
            {
                counter += Time.deltaTime;
                gameObject.transform.localScale = Vector3.Lerp(
                    originalScale,
                    destinationScale,
                    counter / duration
                );
                yield return null;
            }
            isScaling = false;
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
        #endregion
        protected virtual void OnTimeOut() { }

        public abstract void Logic();

        private void Update()
        {
            DestroyByTime();
        }
    }
}
