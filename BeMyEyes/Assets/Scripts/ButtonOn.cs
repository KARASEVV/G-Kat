using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonOn : MonoBehaviour
{
    public GameObject Trig;
    void Start()
    {
        
    }
    public void TrigOn()
    {
        Trig.SetActive(true);
    }
}
