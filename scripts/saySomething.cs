using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class saySomething : MonoBehaviour
{
    public string Deepity;
    public GameObject inputFeild;
    public GameObject outputFeild;

    public void SayDeepity()
    {
        Deepity = inputFeild.GetComponent<Text>().text;
        outputFeild.GetComponent<Text>().text = Deepity + "Wow. That's so deep, man.";
    }
}
