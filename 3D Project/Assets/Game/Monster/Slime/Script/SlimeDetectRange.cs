using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeDetectRange : MonoBehaviour
{
    [SerializeField]
    GameObject slimeObject;
    [SerializeField]
    SlimeMovement SlimeMovement;
    [SerializeField]
    SlimeAttackRange slimeAttackRange;

    private void Update() 
    {
        gameObject.transform.position = new Vector3(slimeObject.transform.position.x, slimeObject.transform.position.y, slimeObject.transform.position.z);
    }

    void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player" && slimeAttackRange.isAttacking == false)
        {
            SlimeMovement.SlimeMoving();
        }
    }
}
