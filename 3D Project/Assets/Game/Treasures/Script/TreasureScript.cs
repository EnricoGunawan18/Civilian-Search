using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureScript : MonoBehaviour
{
    [SerializeField]

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
}
