using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImagemP : MonoBehaviour
{
    [SerializeField] private SpriteRenderer imagem;

    void Update()
    {
        if(imagem.enabled == true && Input.GetButtonDown("left ctrl"))
        {
            imagem.enabled = false;
        }else if(imagem.enabled == false && Input.GetButtonDown("left ctrl"))
        {
            imagem.enabled = true;
        }
    }

    
}