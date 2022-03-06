using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class IniciarVideo : MonoBehaviour
{

    public VideoPlayer videoPlayer;
    public GameObject ligado;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ligado.activeInHierarchy == true) {
            videoPlayer.enabled = true;
        }
        
        if(videoPlayer.isPaused == true) {
            videoPlayer.enabled = false;
        }
    }
}
