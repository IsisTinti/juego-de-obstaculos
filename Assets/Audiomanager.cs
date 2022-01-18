using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;


public class Audiomanager : MonoBehaviour
{
    public AudioClip[] clips;
    public static Audiomanager elaudiomanager; 
    // Start is called before the first frame update
    /*void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            ChangeAudio(clips[1]);
        }
        else
        {
            Debug.Log(SceneManager.GetActiveScene().buildIndex);
        }
    }

    // Update is called once per frame
    private void Awake()
    {
        if (elaudiomanager == null)
        {
            elaudiomanager = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void ChangeAudio(AudioClip newSong)
    {
        GetComponent<AudioSource>().clip = newSong;
        GetComponent<AudioSource>().Play();
    }*/
}
