using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BackToTitle : MonoBehaviour
{
    [SerializeField]
    Button titleButton;

    // Start is called before the first frame update
    void Start()
    {
        titleButton.onClick.AddListener(TitleButtonPress);
    }

    // Update is called once per frame
    void TitleButtonPress()
    {
        SceneManager.LoadScene("Title");
    }
}
