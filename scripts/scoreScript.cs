using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreScript : MonoBehaviour
{
    public  GameObject scoreDisplay;

    // Update is called once per frame
    void Update()
    {
        scoreDisplay.GetComponent<Text>().text = Globals.score + "  Deep Score";
    }
}
