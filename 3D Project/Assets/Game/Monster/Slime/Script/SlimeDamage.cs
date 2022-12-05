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
    Slider healthSlider;

    public float damage;

    private void Start() 
    {
        player = GameObject.FindWithTag("Player");
        playerAnim = player.GetComponent<Animator>();
        healthSlider = GameObject.Find("HealthBar").GetComponent<Slider>();
    }
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        bool isDamaged = playerAnim.GetBool("Damaged");
        if(other.tag == "Player" && isDamaged == false)
        {
            playerAnim.SetBool("Damaged", true);
            healthSlider.value -= damage;
        }
    }
}
