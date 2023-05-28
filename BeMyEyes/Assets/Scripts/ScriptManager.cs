using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class ScriptManager : MonoBehaviour
{
    public Text quote_label;
    public string start_path = "Assets/Dialogs/dialog.txt";
    string[] speach;
    public GameObject[] QuestItem;
    public int dialog_index = 0;
    public bool resume = true;
    int index_1 = 0;
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
        StartCoroutine(FontChange(quote[0]));
        //print(quote[0]);
        if(quote[1]!="-"){
            QuestItem[int.Parse(quote[1])].SetActive(true);
            resume = false;
        }
        if(quote[2]!="-"){
            PlayerPrefs.SetInt("NextLevel", int.Parse(quote[2]));
            PlayerPrefs.Save();
        }
    }
    IEnumerator FontChange(string _quote){
        for (int i=1; i<=_quote.Length; i++) {
            quote_label.text = _quote.Substring(0, i);
            yield return new WaitForSeconds(.1f);
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
        dialog_index++;
            if(dialog_index<speach.Length)
                printSpeach(speach,dialog_index);
    }
    public void OnResume_1(){
        index_1++;
        if(index_1==5){
            OnResume();
        }
        
    }
}