using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inputDeepity : MonoBehaviour
{
    public string Deepity;
    public GameObject inputFeild;
    public GameObject outputFeild;

    public void SayDeepity()
    {
        if (!Globals.canTurnHead)
        {
            Deepity = inputFeild.GetComponent<Text>().text;
            outputFeild.GetComponent<Text>().text = Deepity + "   Wow. That's so deep, man.";
            Globals.canTurnHead = true;
            print("you can now turn your head");
        }
        
    }
}
