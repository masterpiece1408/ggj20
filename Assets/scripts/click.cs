using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class click : MonoBehaviour
{
    public Text scoreText;
    private int score;
    public void OnClick()   
    {
        score++;
        scoreText.text = score.ToString();
    }
}
