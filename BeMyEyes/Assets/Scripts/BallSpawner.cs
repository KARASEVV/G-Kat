using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject Ball;
    void Start()
    {
        StartCoroutine(BallSpawn());
    }
    IEnumerator BallSpawn(){
        Instantiate(Ball, transform.position, transform.rotation);
        yield return new WaitForSeconds(Random.Range(1f, 5f));
        StartCoroutine(BallSpawn());
    }
}
