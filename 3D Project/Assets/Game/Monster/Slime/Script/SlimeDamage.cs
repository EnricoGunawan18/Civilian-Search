using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlimeDamage : MonoBehaviour
{
    [SerializeField]
    GameObject player;
    [SerializeField]
    Animator playerAnim;

    [SerializeField]
    Canvas canvas;
    [SerializeField]
    Slider healthSlider;

    private void Start() {
        player = GameObject.FindWithTag("Player");
        playerAnim = player.GetComponent<Animator>();
        canvas = transform.root.GetComponentInParent<Canvas>();
        //healthSlider = 
    }
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            playerAnim.SetBool("Damaged", true);
        }
    }
}
