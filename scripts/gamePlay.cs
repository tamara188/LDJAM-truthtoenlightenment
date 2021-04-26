using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamePlay : MonoBehaviour
{
    public GameObject dudeBroOriginal;
    public float zMax = 58f;
    public float zMin = -11f;
    public float xMax = 53f;
    public float xMin = -13f;
    public GameObject winText;
    // Start is called before the first frame update
    void Start()
    {
        CreateDudeBros(25);
        winText.SetActive(false);

    }
    void CreateDudeBros(int numDudeBros)
    {
        for(int i = 0; i < numDudeBros; i++)
        {
            Quaternion rotation = Quaternion.Euler(dudeBroOriginal.transform.eulerAngles.x,Random.Range(0f,360f),dudeBroOriginal.transform.eulerAngles.z);

            GameObject NPCClone = Instantiate(dudeBroOriginal, new Vector3(Random.Range(xMin, xMax), dudeBroOriginal.transform.position.y, Random.Range(zMin, zMax)),rotation);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
