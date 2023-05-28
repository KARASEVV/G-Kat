using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    bool IsOnPlace;
    public GameObject icon;
    // Start is called before the first frame update
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
                int lvl_id = PlayerPrefs.GetInt("NextLevel");
                SceneManager.LoadScene(lvl_id);
            }
        }
    }
}
