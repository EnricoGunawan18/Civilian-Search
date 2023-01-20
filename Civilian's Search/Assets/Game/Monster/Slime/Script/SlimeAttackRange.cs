using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeAttackRange : MonoBehaviour
{
    [SerializeField]
    GameObject slimeObject;
    [SerializeField]
    Animator slimeAnimator;

    [SerializeField]
    Rigidbody rb;

    public float leap;

    public bool isAttacking = false;
    bool coroutineRunning = false;

    private void Update() 
    {
        gameObject.transform.position = new Vector3(slimeObject.transform.position.x, slimeObject.transform.position.y, slimeObject.transform.position.z);
    }

    void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
            isAttacking = true;
            InvokeRepeating("SlimeAttacking", 0f, 3f);
        }
    }

    private void OnTriggerExit(Collider other) 
    {
        isAttacking = false;
        slimeAnimator.SetBool("isAttacking", false);
        CancelInvoke("SlimeAttacking");
    }

    void SlimeAttacking()
    {
        slimeAnimator.SetBool("isAttacking", true);
		rb.AddForce (Vector3.up * leap, ForceMode.VelocityChange);
		rb.AddForce (Vector3.forward * leap, ForceMode.VelocityChange);
    }
}
