using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityChan;
using UnityEngine.UI;

public class TreasureScript : MonoBehaviour
{
    [SerializeField]
    GameObject player;
    [SerializeField]
    UnityChanControlScriptWithRgidBody unityController;

    [SerializeField]
    GameObject canvas;
    [SerializeField]
    GameObject clearUI;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        unityController = player.GetComponent<UnityChanControlScriptWithRgidBody>();
        canvas = GameObject.Find("Canvas");
        clearUI = canvas.transform.Find("GameClear").gameObject;
    }

    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
            clearUI.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
