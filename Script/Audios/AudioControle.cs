using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControle : MonoBehaviour
{
    public AudioSource audioSourceMusicaDeFundo;
    public AudioClip[] musicasDeFundo;
   
    void Start(){

        AudioClip musicaDeFundoDessaFase = musicasDeFundo[0];
        audioSourceMusicaDeFundo.clip = musicaDeFundoDessaFase;
        audioSourceMusicaDeFundo.Play();
    }
   
    private float VolumeMusica = 1f;

    // Update is called once per frame
    void Update()
    {
        //AudioSource.volume = VolumeMusica;
    }

    public void ConfiguraçãoVolume(float volume)
    {
        VolumeMusica = volume;
    }
}
