using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class ScoreText : MonoBehaviour
{
    [SerializeField] private PlayerScoreSO score;
    private Text playerScore;

    private void Awake()
    {
        playerScore = GetComponent<Text>();
    }

    private void Update()
    {
        ScoreCount();
    }

    private void ScoreCount()
    {
        playerScore.text = ("Score: " + score.points);
    }
}
