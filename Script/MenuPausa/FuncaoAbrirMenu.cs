using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuncaoAbrirMenu : MonoBehaviour
{
      public GameObject FuncaoPausa;

    // Update is called once per frame

   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {             
            Dijuntor();
        }   
    }
    bool isPause = false;
    void Dijuntor(){
      if(isPause == false)
        {
            FuncaoPausa.SetActive(true);
            isPause = true;
        } else if(isPause == true)
            {
                FuncaoPausa.SetActive(false);
                isPause = false;
            }
    }
}
