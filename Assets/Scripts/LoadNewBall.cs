using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadNewBall : MonoBehaviour
{
    [SerializeField] GameObject ball;
    void Update()
    {
        CheckForSpawn();
    }


    void CheckForSpawn() {
        if (GameObject.FindWithTag("Ball") == null) {
            Instantiate(ball);
        }
    }

}
