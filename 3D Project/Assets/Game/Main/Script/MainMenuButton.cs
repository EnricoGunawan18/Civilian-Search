using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuButton : MonoBehaviour
{
    [SerializeField]
    Button[] mainMenuButton;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < mainMenuButton.Length; i++)
        {
            mainMenuButton[i].onClick.AddListener(backToMainMenu);
        }
    }

    // Update is called once per frame
    void backToMainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Title");
    }
}
