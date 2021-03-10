using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollison : MonoBehaviour
{
    public PlayerMovement movement;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Obstacle")
        {
            Debug.Log("We hit a Obstacle");
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
;
        }
    }
}
