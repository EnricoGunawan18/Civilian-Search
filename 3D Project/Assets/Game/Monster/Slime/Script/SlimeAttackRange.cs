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
            if(!coroutineRunning)
            {
                StartCoroutine(SlimeAttacking());
                coroutineRunning = true;
            }
        }
    }

    private void OnTriggerExit(Collider other) 
    {
        StopCoroutine(SlimeAttacking());
        isAttacking = false;
        slimeAnimator.SetBool("isAttacking", false);
    }

    IEnumerator SlimeAttacking()
    {
        slimeAnimator.SetBool("isAttacking", true);
		rb.AddForce (Vector3.up * leap, ForceMode.VelocityChange);
		rb.AddForce (Vector3.forward * leap, ForceMode.VelocityChange);
        Debug.Log("a");
        yield return new WaitForSeconds(2);
        coroutineRunning = false;
    }
}
