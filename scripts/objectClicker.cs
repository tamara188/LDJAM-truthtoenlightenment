
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
public class objectClicker : MonoBehaviour
{

    public GameObject outputFeild;
    public string Deepity;
    public GameObject inputFeild;
    public GameObject theCurrentDude;
    public GameObject scoreDisplay;
    public GameObject winNoise;
    public GameObject loseNoise;
    public GameObject wonGame;
    public void SayDeepity()
    {
        if(theCurrentDude == null)
        {
            Globals.canTurnHead = true;
            print("you can now turn your head");
            return;
        }
        if (!Globals.canTurnHead)
        {
            print(inputFeild.GetComponent<Text>().text);
            Deepity = inputFeild.GetComponent<Text>().text;
            Globals.canTurnHead = true;
            print("you can now turn your head");
            bool wonMatch = false;
            for (int i = 0; i < Globals.deepChecks.Length; i++)
            {
                if (inputFeild.GetComponent<Text>().text.Contains(Globals.deepChecks[i]))
                {
                    wonMatch = true;
                    
                }
            }
            if (wonMatch)
            {
                outputFeild.GetComponent<Text>().text = "Wow, I'll have to go think about that for a while. That's really deep man.";
                Globals.score++;
                scoreDisplay.GetComponent<Text>().text = Globals.score + "  Deep Score";
                print(Globals.score);
                
                if(theCurrentDude.name == "Bro-ss")
                {
                    wonGame.SetActive(true);
                }
                Destroy(theCurrentDude, 0.5f);
                GameObject noiseClone = Instantiate(winNoise, winNoise.transform);
                Destroy(noiseClone,3f);
                
            }
            else
            {
                outputFeild.GetComponent<Text>().text = "I don't think that's really all that deep.";
                GameObject noiseClone = Instantiate(loseNoise, loseNoise.transform);
                Destroy(noiseClone,3f);
            }
            
        }
        

    }
    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            print("got into mouse button down");
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 100f))
            {
                if (hit.transform)
                {
                    print("got into hit.transform");
                    PrintDeepity(hit.transform.gameObject);
                }
            }
        }
    }

    public void PrintDeepity(GameObject dude)
    {
        Globals.canTurnHead = false;
        print("got into print deepity");
        print("clicked on " + dude.name);

        Cursor.lockState = CursorLockMode.None;
        if (dude.name == "rock4paint(Clone)" || dude.name == "rock4paint")
        {
            print("got into if rockdude");
            theCurrentDude = dude;
            outputFeild.GetComponent<Text>().text = Globals.OpponentDeepities[Random.Range(0, Globals.OpponentDeepities.Length)];
        }
        else if(dude.name == "TutorialDude")
        {
            outputFeild.GetComponent<Text>().text = "Welcome. We are all on a path to enlightenment. To reach your goal you must find the deepest truth. Once you have found it, you may seek the golden one. He will judge you. ";
        }
        else if(dude.name == "Bro-ss")
        {
            if(Globals.score > 15)
            {
                outputFeild.GetComponent<Text>().text = Globals.bossSaying;
                theCurrentDude = dude;
            }
            else
            {
                outputFeild.GetComponent<Text>().text = "You have yet to transend enough to speak with me. Go to the other first.";
            }
        }else if(dude.name == "Terrain")
        {
            print("clicked on terrain");
        }
        

    }


}
