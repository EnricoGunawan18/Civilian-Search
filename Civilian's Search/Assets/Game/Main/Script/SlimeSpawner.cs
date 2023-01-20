using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeSpawner : MonoBehaviour
{
    [SerializeField]
    GameObject slime;
    [SerializeField]
    GameObject player;

    [SerializeField]
    int slimeNumber;
    // Start is called before the first frame update
    void Awake()
    {
        for(int i = 0; i < slimeNumber; i++)
        {
            float rand = Random.Range(0,50);         
            float posX = (player.transform.position.x + (rand * (Random.Range(0,2) * 2 - 1)));
            float posZ = (player.transform.position.z + ((50 - rand) * (Random.Range(0,2) * 2 - 1)));
            Vector3 position = new Vector3(posX, 100, posZ);
            
            if(Physics.Raycast(position,Vector3.down, out RaycastHit hit))
            {
                Instantiate(slime, hit.point, Quaternion.identity);
            }
        }
    }

    public void Spawn()
    {
        float rand = Random.Range(0,50);         
        float posX = (player.transform.position.x + (rand * (Random.Range(0,2) * 2 - 1)));
        float posZ = (player.transform.position.z + ((50 - rand) * (Random.Range(0,2) * 2 - 1)));
        Vector3 position = new Vector3(posX, 100, posZ);
        
        if(Physics.Raycast(position,Vector3.down, out RaycastHit hit))
        {
            Instantiate(slime, hit.point, Quaternion.identity);
        }
    }
}
