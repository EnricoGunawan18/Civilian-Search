using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeDetectRange : MonoBehaviour
{
    [SerializeField]
    SlimeMovement SlimeMovement;
    [SerializeField]
    SlimeAttackRange slimeAttackRange;

    void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player" && slimeAttackRange.isAttacking == false)
        {
            SlimeMovement.SlimeMoving();
        }
    }
}
