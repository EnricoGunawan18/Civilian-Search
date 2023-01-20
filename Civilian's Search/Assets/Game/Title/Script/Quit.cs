using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quit : MonoBehaviour
{
    [SerializeField]
    Button quitButton;
    // Start is called before the first frame update
    void Start()
    {
        quitButton.onClick.AddListener(QuitButtonPress);
    }

    // Update is called once per frame
    void QuitButtonPress()
    {
        Application.Quit();
    }
}
