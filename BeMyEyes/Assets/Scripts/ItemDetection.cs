using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDetection : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision col)
    {
        if(col.collider.tag=="Point"){
            print("Blya");
            gameObject.layer = 0;
        }
    }
}
