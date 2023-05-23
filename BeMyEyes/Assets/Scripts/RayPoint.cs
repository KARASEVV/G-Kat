using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayPoint : MonoBehaviour
{
    public Transform Pointer;
    Ray ray;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Lidar());
    }

    // Update is called once per frame
    void Update()
    {
        ray = new Ray(transform.position, transform.forward);
        Debug.DrawRay(transform.position, transform.forward*100f, Color.yellow);

        /*RaycastHit hit;
        if(Physics.Raycast(ray, out hit)){
            Pointer.position = hit.point;
            Instantiate(Pointer, Pointer.position, Pointer.rotation);
            hit.collider.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        }*/
    }
    IEnumerator Lidar(){
        /*Ray ray = new Ray(transform.position, transform.forward);
        Debug.DrawRay(transform.position, transform.forward*100f, Color.yellow);*/

        RaycastHit hit;
        if(Physics.Raycast(ray, out hit)){
            Pointer.position = hit.point;
            Instantiate(Pointer, Pointer.position, Pointer.rotation);
            hit.collider.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        }
        yield return new WaitForSeconds(.1f);
        StartCoroutine(Lidar());
    }
}
