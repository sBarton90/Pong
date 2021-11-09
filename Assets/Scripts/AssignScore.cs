using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AssignScore : MonoBehaviour
{
    [SerializeField] Text playerScoreText;
    int score;

    public void AddToScore(int amountToAdd) {
        score += amountToAdd;
    }
    public void IncrementScore() {
        playerScoreText.text = "" + score;
    }

    public int GetScore() {
        return score;
    }
}
