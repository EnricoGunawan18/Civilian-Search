using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreScreen : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI score;   

    int[] highScore;
    int newScore;
    
    // Start is called before the first frame update
    void Start()
    {
        score.text = "";
        highScore = new int[6];
        newScore = PlayerPrefs.GetInt("NewScore");

        int temp = newScore;
        int temp2;
        for(int i = 0; i < highScore.Length - 1; i++)
        {
            if(temp > highScore[i])
            {
                temp2 = temp;
                temp = PlayerPrefs.GetInt("Score" + i);
                PlayerPrefs.SetInt("Score" + i, temp2);
                PlayerPrefs.SetInt("Score" + i + 1, temp);
            }
        }
        
        for(int i = 0; i < highScore.Length - 1; i++)
        {
            highScore[i] = PlayerPrefs.GetInt("Score"+i);
            score.text = score.text + (i + 1).ToString() + " : " + highScore[i].ToString() + "<br>";
        }
    }
}
