using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class LvL_2 : MonoBehaviour
{
    bool IsOnPlace;
    public ScriptManager SM;
    public GameObject icon, next;
    public Text lbl;
    public string s;

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
        if(Input.GetKeyDown(KeyCode.E)){
            if(IsOnPlace){
                lbl.text=s;
                SM.OnResume_1();
            }
            
        }
    }
}