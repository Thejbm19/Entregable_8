using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AudioManager : MonoBehaviour
{
    public AudioClip[] musicList;
    private int songIndex;
    private AudioSource headPhones;
    public string[] songNames;
    public TextMeshProUGUI Name;

    void Start()
    {
        headPhones = GetComponent<AudioSource>();

        headPhones.clip = musicList[songIndex];
        changeName();
    }


    public void songForward()
    {
        songIndex++;

        if(songIndex > musicList.Length-1)
        {
            songIndex = 0;
        }
        headPhones.clip = musicList[songIndex];

        songPlay();
        changeName();
    }

    public void songBack()
    {
        songIndex--;
        if (songIndex < 0)
        {
            songIndex = musicList.Length-1;
        }
        headPhones.clip = musicList[songIndex];

        songPlay();
        changeName();
    }

    public void songPause()
    {
        headPhones.Pause();
    }

    public void songPlay()
    {
        headPhones.Play();
    }

    public void songRandom()
    {
        songIndex = Random.Range(0, musicList.Length);

        headPhones.clip = musicList[songIndex];

        songPlay();
        changeName();
    }

    public void changeName()
    {
        Name.text = songNames[songIndex];
    }
}
