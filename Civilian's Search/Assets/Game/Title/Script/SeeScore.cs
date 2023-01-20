using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SeeScore : MonoBehaviour
{
    [SerializeField]
    Button scoreButton;

    // Start is called before the first frame update
    void Start()
    {
        scoreButton.onClick.AddListener(ScoreButtonPress);
    }

    // Update is called once per frame
    void ScoreButtonPress()
    {
        PlayerPrefs.SetInt("NewScore", 0);
        SceneManager.LoadScene("Score");
    }
}
