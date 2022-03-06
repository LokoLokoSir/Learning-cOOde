using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class FuncaoBotoes : MonoBehaviour
{

     //Função trocar para Menu Principal
    public void IrTelaInicial()
    {
      SceneManager.LoadScene("Tela de Menu");
    }

     //Função trocar para Lobby
    public void IrLobby()
    {
      SceneManager.LoadScene("Lobby");
    }

     //Função trocar para Sair
    public void IrSair()
    {
      Application.Quit();
    }


   
        
        
    
}
