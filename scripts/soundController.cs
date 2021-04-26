using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundController : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip audioClip;
    public string soundPath;
    public const string ambient = "ambient.wav";
    public const string loseMatch = "loseMatch.wav";
    public const string winMatch = "winMatch.wav";
    public const string winGame = "winGame.wav";

    private void Awake()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        soundPath = "file://"+Application.streamingAssetsPath+"/Sound/";
        StartCoroutine(LoadAudio());
       
    }
    private IEnumerator LoadAudio()
    {
        WWW request = GetAudioFromFile(soundPath, ambient);
        yield return request;

        audioClip = request.GetAudioClip();
        audioClip.name = ambient;
    }

    private void PlayAudioFile()
    {
        audioSource.clip = audioClip;
        audioSource.Play();
        audioSource.loop = true;
    }
    public WWW GetAudioFromFile(string path,string filename)
    {
        string audioToLoad = path + filename;
        WWW request = new WWW(audioToLoad);
        return request;
    }
}
