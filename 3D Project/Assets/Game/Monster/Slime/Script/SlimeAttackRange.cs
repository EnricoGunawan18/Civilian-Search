using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeAttackRange : MonoBehaviour
{
    [SerializeField]
    GameObject slimeObject;
    [SerializeField]
    Animator slimeAnimator;

    public bool isAttacking = false;

    private void Update() 
    {
        gameObject.transform.position = new Vector3(slimeObject.transform.position.x, slimeObject.transform.position.y, slimeObject.transform.position.z);
    }

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
