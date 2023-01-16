using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{
    public static bool startUp = true;

    
    // Start is called before the first frame update
    void Start()
    {
        if(startUp == true)
        {
            startUp = false;
            for(int i = 0; i < 5; i++)
            {
                PlayerPrefs.SetInt("Score" + i, 0);
            }
        }
    }
}
