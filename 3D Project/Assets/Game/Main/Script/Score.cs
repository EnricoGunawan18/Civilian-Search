using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI timeText;
    [SerializeField]
    TextMeshProUGUI distanceText;
    [SerializeField]
    Button scoreMenu;
    [SerializeField]
    GameObject player;
    [SerializeField]
    GameObject instantiatedObject;

    [SerializeField]
    Slider healthSlider;

    [SerializeField]
    TreasureSpawner treasureSpawner;

    float timer;
    int score;
    int initialdis;
    int distance;
    int multiplier = 1;
    // Start is called before the first frame update
    void Start()
    {
        instantiatedObject = treasureSpawner.instantiatedObject;
        timer = 0;
        initialdis = (int)Vector3.Distance(player.transform.position, instantiatedObject.transform.position);

        int mult = 50;
        while(initialdis > mult)
        {
            multiplier++;
            mult += 50;
        }
        distanceText.text = initialdis.ToString();
        scoreMenu.onClick.AddListener(ScoreScreen);
    }

    // Update is called once per frame
    void Update()
    {
        if(instantiatedObject)
        {
            timer += Time.deltaTime;
            distance = (int)Vector3.Distance(player.transform.position, instantiatedObject.transform.position);
        }
        else
        {
            distance = 0;
            score = ((int)initialdis * 100 * multiplier * (int)healthSlider.value) / ((int)timer * 100);
        }
        
        int text = (int)timer;
        timeText.text = "Time : " + text.ToString();
        distanceText.text = "Distance : " + distance.ToString();
    }

    void ScoreScreen()
    {
        PlayerPrefs.SetInt("NewScore", score);
        Debug.Log(score);
        Time.timeScale = 1;
        SceneManager.LoadScene("Score");
    }
}
