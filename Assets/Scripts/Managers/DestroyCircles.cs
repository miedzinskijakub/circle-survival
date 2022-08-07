using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCircles : MonoBehaviour
{
    [Header("Audio reference")]
    [SerializeField]
    AudioClip circlePopSound;

    [SerializeField]
    AudioClip bombExplodeSound;

    [Header("Particle reference")]
    [SerializeField]
    GameObject particleEffect;

    [Header("GameSession reference")]
    [SerializeField]
    GameSession gameSession;

    private bool hasStarted = false;

    void Update()
    {
        gameSession = gameSession.GetComponent<GameSession>();
        DestroyCircle();
    }

    private void DestroyCircle()
    {
        if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began))
        {
            RaycastHit2D hit = Physics2D.Raycast(
                Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position),
                Vector2.zero
            );

            if (hit.collider != null && hit.transform.tag == "circle")
            {
                var interactable = hit.transform.gameObject.GetComponent<IDestroyable>();
                if (interactable == null) return;
                interactable.Interact();

                PlayParticle(hit);
                PlaySound(circlePopSound, hit);
                gameSession.AddToScore();
            }
            else if (hit.collider != null && hit.transform.tag == "bomb")
            {
                var interactable = hit.transform.gameObject.GetComponent<IDestroyable>();
                if (interactable == null) return;
                interactable.Interact();

                PlaySound(bombExplodeSound, hit);
                Destroy(hit.collider.gameObject);
            }
            else if (hit.collider == null && hasStarted == false)
            {
                hasStarted = true;
                gameSession.StartGame();
            }
        }
    }

    private void PlayParticle(RaycastHit2D hit)
    {
        GameObject particleGameObject = Instantiate(
            particleEffect,
            hit.transform.position,
            hit.transform.rotation
        );
        Destroy(particleGameObject, 2f);
    }

    private void PlaySound(AudioClip audio, RaycastHit2D hit)
    {
        AudioSource.PlayClipAtPoint(audio, hit.transform.position, 1.0f);
    }
}
