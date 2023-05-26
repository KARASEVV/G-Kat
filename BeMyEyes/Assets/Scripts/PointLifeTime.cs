using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointLifeTime : MonoBehaviour
{
    public float time;
    void Start()
    {
        StartCoroutine(Life());
    }
    IEnumerator Life(){
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }
}
