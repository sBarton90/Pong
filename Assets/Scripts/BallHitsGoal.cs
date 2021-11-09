using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallHitsGoal : MonoBehaviour
{
    [SerializeField] AssignScore assignScore;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Ball") {
            assignScore.AddToScore(1);
            assignScore.IncrementScore();
            Destroy(other.gameObject);
        }
    }
}
