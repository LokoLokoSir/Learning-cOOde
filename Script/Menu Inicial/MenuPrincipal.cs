using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    public void Sair()
    {
        Application.Quit();
    }

    public void Comecar()
    {
        SceneManager.LoadScene("Inicio");
    }
 
    
}
