using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class paraLobbyFinal1 : MonoBehaviour
{

  
    public void OnTriggerEnter2D( Collider2D collision)
  {
      if (collision.gameObject.CompareTag("Player"))
      {
         SceneManager.LoadScene("LobbyFinal");
     }
  }
}
