using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureSpawner : MonoBehaviour
{
    [SerializeField]
    GameObject treasure;
    // Start is called before the first frame update
    void Awake()
    {
        int posX = Random.Range(100, 900);
        int posY = 3;
        int posZ = Random.Range(100, 900);
        Vector3 position = new Vector3(posX, posY, posZ);
        Instantiate(treasure, position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
