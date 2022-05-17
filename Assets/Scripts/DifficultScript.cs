using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultScript : MonoBehaviour
{
    [Header("Difficult Settings")]
    [Tooltip("The lower the value, the harder it is.")]
    [Range(1f, 50f)][SerializeField] float difficultFactor = 1f;
    
    public float generateDifficult()
    {
        float number;
        number = Mathf.Sqrt(difficultFactor / Time.time);
        
        return number;

    }

}
