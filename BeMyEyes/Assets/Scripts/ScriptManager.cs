using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class ScriptManager : MonoBehaviour
{
    public string start_path = "Assets/Dialogs/dialog.txt";
    string[] speach;
    public GameObject[] QuestItem;
    int dialog_index = 0;
    public bool resume = true;
    void Start() {
        speach = getText(start_path);
        printSpeach(speach,0);
    }
    private string[] getText(string _path) {
        StreamReader reader = new StreamReader(_path); 
        string[] speach = reader.ReadToEnd().Split("\n");
        reader.Close();
        return speach;
    }
    private void printSpeach(string[] _text, int ind) {
        string[] quote = _text[ind].Split("|");
        print(quote[0]);   
        if(quote[1]!="null"){
            QuestItem[int.Parse(quote[1])].SetActive(true);
            resume = false;
        }
    }
    void Update(){
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if(resume){
                dialog_index++;
                if(dialog_index<speach.Length)
                    printSpeach(speach,dialog_index);
            }
            
        }
    }
    public void OnResume(){
        resume=true;
    }
}