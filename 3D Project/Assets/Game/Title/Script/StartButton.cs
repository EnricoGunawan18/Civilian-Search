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
        startButton.onClick.AddListener(startButtonPress);
    }

    // Update is called once per frame
    void startButtonPress()
    {
        SceneManager.LoadScene("Main");
    }
}
