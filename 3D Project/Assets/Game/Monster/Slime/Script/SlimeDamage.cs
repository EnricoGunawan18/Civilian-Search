using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeDamage : MonoBehaviour
{
    [SerializeField]
    GameObject player;
    [SerializeField]
    Animator playerAnim;

    private void Start() {
        player = GameObject.FindWithTag("Player");
        playerAnim = player.GetComponent<Animator>();
    }
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            playerAnim.SetBool("Damaged", true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
