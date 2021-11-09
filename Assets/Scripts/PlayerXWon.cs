using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerXWon : MonoBehaviour
{
    [SerializeField] Text playerOneScore;
    [SerializeField] Text playerTwoScore;
    [SerializeField] Text p1Win;
    [SerializeField] Text p2Win;

    void Update()
    {
        CheckForWinner();
    }

    void CheckForWinner() {
        if (playerOneScore.text == "" + 3) {
            p1Win.GetComponent<Text>().enabled = true;
            Time.timeScale = 0;
            
        } else if (playerTwoScore.text == "" + 3) {
            p2Win.GetComponent<Text>().enabled = true;
            Time.timeScale = 0;
            
        }
    }
}
