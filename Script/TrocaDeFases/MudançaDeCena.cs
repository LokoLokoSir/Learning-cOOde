using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MudançaDeCena : MonoBehaviour
{
    public GameObject UIElement;
    
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Player")) {
                UIElement.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        if(other.CompareTag("Player")) {
            UIElement.SetActive(false);
        }
    }
}