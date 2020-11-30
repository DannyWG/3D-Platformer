// Danny Gnaulati point tracker script
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PowerUpScore : MonoBehaviour
{
    public static PowerUpScore instance;
    int score;
    public TextMeshProUGUI text;
    // making sure the score starts at zero
    private void Start()
    {
        if(instance == null)
        {
            instance = this;
        }

    }
    // When the player collects the collectable the score will increase
    public void ChangeScore(int CoinValue)
    {
        score += CoinValue;
        text.text = "x" + score.ToString();
    }


}
