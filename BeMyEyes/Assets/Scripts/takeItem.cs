using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class takeItem : MonoBehaviour
{
    bool IsOnPlace;
    public GameObject icon, item;
    public ScriptManager SM;
    void Start()
    {
        
    }
    void OnTriggerEnter(Collider col){
        if(col.tag=="Player"){
            IsOnPlace = true;
            icon.SetActive(true);
        }

    }
    void OnTriggerExit(Collider col){
        if(col.tag=="Player"){
            IsOnPlace = false;
            icon.SetActive(false);
        }
        
    }
    void Update(){
        if (Input.GetKeyDown(KeyCode.E)){
            if(IsOnPlace){
                item.SetActive(false);
                SM.OnResume();
            }
        }
    }
}
