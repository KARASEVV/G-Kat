using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointLifeTime : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(Life());
    }
    IEnumerator Life(){
        yield return new WaitForSeconds(5f);
        Destroy(gameObject);
    }
}
