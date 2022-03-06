using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class codigoParaVideo : MonoBehaviour
{
          public GameObject VideoPausa;

    // Update is called once per frame

   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {             
            Dijuntor();
        }   
    }
    bool isPause = true;
    void Dijuntor(){
      if(isPause == true)
        {
            VideoPausa.SetActive(false);
            isPause = false;
        } else if(isPause == false)
            {
                VideoPausa.SetActive(true);
                isPause = true;
            }
    }
}