using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Events;

using TMPro;

public class UIManager : MonoBehaviour
{
    const string SCORE_STRING = "Score: {0}";
    private int score;

    public int Score { get { return score; } }

    [SerializeField]
    private TMPro.TMP_Text scoreText;
    
    private void Start()
    {
        Events.instance.CoinCollect.AddListener(UpdateScore);

        UpdateScore(0);
    }

    public void UpdateScore(int val)
    {
        score += val;

        if(scoreText!=null)
            scoreText.text = string.Format(SCORE_STRING, score);
    }
}
