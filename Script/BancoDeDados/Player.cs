using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class Player : MonoBehaviour
{
    public InputField nome;
    public InputField score1;
    public InputField score2;
    public InputField score3;
    public InputField score4;
    public InputField scoretotal;

    public void NewScoreElement(string _name,int _score1, int _score2, int _score3, int _score4, int _scoretotal)
    {
        nome.text = _name;
        score1.text = _score1.ToString();
        score2.text = _score2.ToString();
        score3.text = _score3.ToString();
        score4.text = _score4.ToString();
        scoretotal.text = _scoretotal.ToString();
    }
}
