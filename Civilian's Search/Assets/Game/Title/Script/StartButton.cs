using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    [SerializeField]
    Button startButton;

    // Start is called before the first frame update
    void Start()
    {
        startButton.onClick.AddListener(StartButtonPress);
    }

    // Update is called once per frame
    void StartButtonPress()
    {
        PlayerPrefs.SetInt("NewScore", 0);
        SceneManager.LoadScene("Main");
    }
}
