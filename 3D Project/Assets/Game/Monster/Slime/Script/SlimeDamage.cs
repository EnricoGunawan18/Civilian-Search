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
    bool dead = false;
    float time = 0;

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
        bool isDead = playerAnim.GetBool("IsDead");
        if(other.tag == "Player" && isDamaged == false && isDead == false)
        {
            healthSlider.value -= damage;
            if(healthSlider.value <=0)
            {
                Debug.Log("a");
                playerAnim.Play("DAMAGED01");
                dead = true;
            }
            else
            {
                playerAnim.SetBool("Damaged", true);
            }
        }
    }

    private void Update() 
    {
        if(dead == true)
        {
            if(playerAnim.GetCurrentAnimatorStateInfo(0).normalizedTime >= 0.55f)
            {
                playerAnim.speed = 0;
            }
        }
    }
}
