using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class IniciarDiretorTerminal : MonoBehaviour
{
    public float duracao;
    public PlayableDirector diretorTerminal;
    public PlayableDirector diretorIdeia;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(diretorIdeia.time >= duracao) {
        diretorTerminal.Play();
        }
    }
}
