using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public Font m_font;
    public Text[] letter;
    int i = 0;
    void Start()
    {
        StartCoroutine(FontChange());
    }
    IEnumerator FontChange(){
        yield return new WaitForSeconds(1f);
        letter[i].gameObject.GetComponent<Text>().font = m_font;
        if(i<letter.Length)
            i++;
        StartCoroutine(FontChange());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
