using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class MenuHighScore : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] TextMeshProUGUI highScoreMenu;

    void Start()
    {
        highScoreMenu.text = $"High Score: {PlayerPrefs.GetInt("HighScore")}";
    }

    
   
}
