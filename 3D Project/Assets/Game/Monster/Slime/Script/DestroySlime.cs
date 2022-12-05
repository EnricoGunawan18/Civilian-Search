using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySlime : MonoBehaviour
{
    [SerializeField]
    GameObject player;
    [SerializeField]
    SlimeSpawner slimeSpawner;

    private void Start() 
    {
        player = GameObject.FindWithTag("Player");
        slimeSpawner = GameObject.Find("SlimeSpawner").GetComponent<SlimeSpawner>();
    }

    void Update()
    {
        float dist = Vector3.Distance(player.transform.position, transform.position);
        if(dist >= 51)
        {
            Destroy(this.gameObject);

            slimeSpawner.Spawn();
        }
    }
}
