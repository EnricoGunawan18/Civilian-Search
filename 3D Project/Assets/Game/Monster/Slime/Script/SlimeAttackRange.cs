using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeAttackRange : MonoBehaviour
{
    [SerializeField]
    Animator slimeAnimator;

    public bool isAttacking = false;

    void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
            isAttacking = true;
            slimeAnimator.SetBool("isAttacking", true);
        }
    }

    private void OnTriggerExit(Collider other) 
    {
        isAttacking = false;
        slimeAnimator.SetBool("isAttacking", false);
    }
}
