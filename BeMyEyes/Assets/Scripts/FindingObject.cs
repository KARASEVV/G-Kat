using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindingObject : MonoBehaviour
{
    public GameObject button;
    public ScriptManager SM;

    public void Finded()
    {
        button.SetActive(true);
    }
    public void res()
    {
        SM.OnResume();
    }
}
