using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultScript : MonoBehaviour
{
    [Header("Difficult Settings")]
    [Tooltip("The lower the value, the harder it is.")]
    [Range(1f, 50f)]
    [SerializeField]
    private float difficultFactor = 1f;

    public float GenerateDifficult()
    {
        float number = 1;

        number -= Time.time / 100;
        return number;
    }
}
