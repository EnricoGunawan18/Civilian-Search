using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeMovement : MonoBehaviour
{
    [SerializeField]
    GameObject player;

    Vector3 playerPos;

    public float slimeSpeed;

    private void Start() 
    {
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    public void SlimeMoving()
    {
        playerPos = player.transform.position;
        gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, playerPos, slimeSpeed * Time.deltaTime);
    }

    public void SlimeRotating()
    {
        playerPos = player.transform.position;
        var targetDirection = playerPos - gameObject.transform.position;

        Vector3 newDirection = Vector3.RotateTowards(gameObject.transform.forward, targetDirection, 45 * Time.deltaTime, 0f);
        gameObject.transform.rotation = Quaternion.LookRotation(newDirection);
    }
}
