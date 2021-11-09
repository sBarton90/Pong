using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] bool isPlayerOne;

    float yVal;
    float moveAmount;
    Rigidbody2D myRigidbody;

    private void Start() {
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update() {
        MovePlayer();
    }

    void MovePlayer() {
        if (isPlayerOne) {
            yVal = Input.GetAxis("Vertical");
        } else {
            yVal = Input.GetAxis("Vertical2");
        }

        moveAmount = yVal * speed;
        myRigidbody.velocity = new Vector2(0, moveAmount);
        
    }
}
