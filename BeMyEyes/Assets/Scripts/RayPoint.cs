using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayPoint : MonoBehaviour
{
    public Transform Pointer;
    Transform clone;
    Ray ray;
    int cubeLayerIndex;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Lidar());
        cubeLayerIndex = LayerMask.NameToLayer("Test");
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
            if(Input.GetMouseButton(0)){
                Pointer.position = hit.point;
                switch (hit.collider.gameObject.name)
                {
                case "Plane":
                clone = Instantiate(Pointer, Pointer.position, Pointer.rotation);
                clone.GetComponent<Renderer>().material.color = Color.blue;
                break;
                case "Ceiling":
                clone = Instantiate(Pointer, Pointer.position, Pointer.rotation);
                clone.GetComponent<Renderer>().material.color = Color.gray;
                break;
                case "Door":
                clone = Instantiate(Pointer, Pointer.position, Pointer.rotation);
                clone.GetComponent<Renderer>().material.color = Color.blue;
                break;
                case "Enviroment":
                clone = Instantiate(Pointer, Pointer.position, Pointer.rotation);
                clone.GetComponent<Renderer>().material.color = Color.magenta;
                break;
                default:
                clone = Instantiate(Pointer, Pointer.position, Pointer.rotation);
                clone.GetComponent<Renderer>().material.color = Color.white;
                break;
                }
            }
            
        }
        yield return new WaitForSeconds(.05f);
        StartCoroutine(Lidar());
    }
}
