using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DialogueSystem
{
    public class DialogueLine : DialogueBaseClass
    {
        private Text textHolder;

        [Header ("Time Parameters")]
        [SerializeField]private float delay;

        [Header ("sound")]
        [SerializeField]private AudioClip sound;

        [SerializeField]private string input;

        private void Awake() {
            textHolder = GetComponent<Text>();

            StartCoroutine(WriteText(input, textHolder, delay, sound));
        }
    }
}

