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


    public void songForward() //Funcion para adelantar las canciones hacia delante
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

    public void songBack()//Funcion para adelantar las canciones hacia atras
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

    public void songPause()//Funcion para pausar las canciones
    {
        headPhones.Pause();
    }

    public void songPlay()//Funcion para iniciar una cancion
    {
        headPhones.Play();
    }

    public void songRandom()//Funcion para iniciar una cnacion random
    {
        songIndex = Random.Range(0, musicList.Length);

        headPhones.clip = musicList[songIndex];

        songPlay();
        changeName();
    }

    public void changeName()//Funcion para canviar el nombre de la cancion del array y mostrar su nombre
    {
        Name.text = songNames[songIndex];
    }
}
