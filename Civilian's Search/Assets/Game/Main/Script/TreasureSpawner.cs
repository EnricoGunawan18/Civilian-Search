using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureSpawner : MonoBehaviour
{
    [SerializeField]
    GameObject treasure;

    public GameObject instantiatedObject;
    // Start is called before the first frame update
    void Awake()
    {
        int posX = Random.Range(100, 900);
        int posZ = Random.Range(100, 900);
        Vector3 position = new Vector3(posX, 100, posZ);

        if(Physics.Raycast(position,Vector3.down, out RaycastHit hit))
        {
            instantiatedObject = Instantiate(treasure, hit.point, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
