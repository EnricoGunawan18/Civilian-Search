using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeSpawner : MonoBehaviour
{
    [SerializeField]
    GameObject slime;

    [SerializeField]
    int slimeNumber;
    // Start is called before the first frame update
    void Awake()
    {
        for(int i = 0; i < slimeNumber; i++)
        {
            int posX = Random.Range(100, 900);
            int posY = 3;
            int posZ = Random.Range(100, 900);

            Vector3 position = new Vector3(posX, posY, posZ);

            Instantiate(slime, position, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
