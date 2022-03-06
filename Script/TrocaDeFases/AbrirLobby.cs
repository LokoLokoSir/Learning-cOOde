using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AbrirLobby : MonoBehaviour
{
    public void IrLobby()
    {
      SceneManager.LoadScene("Lobby");
    }
}
