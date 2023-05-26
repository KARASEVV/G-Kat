using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    float x = 0.0005f;
    void Start()
    {
        StartCoroutine(BallSpawn());
    }
    IEnumerator BallSpawn(){
        x = x*(-1);
        yield return new WaitForSeconds(Random.Range(0.5f, 1f));
        StartCoroutine(BallSpawn());
    }
    void Update()
    {
        gameObject.transform.Translate(x, Random.Range(0.001f, 0.005f), 0f);
    }
}
