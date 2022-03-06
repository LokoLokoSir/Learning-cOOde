using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DialogueSystem
{
    public class DialogueBaseClass : MonoBehaviour
    {
        protected IEnumerator WriteText(string input, Text textHolder, float delay, AudioClip sound){

            for(int i = 0; i < input.Length; i++) {
                textHolder.text += input[i];
                // Inicia som a cada letra.
                Sounds.instance.PlaySound(sound);
                yield return new WaitForSeconds(delay);
            }
        }
    }
}

