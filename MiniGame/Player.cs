using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float speed = 1f;
    private Rigidbody rigb;
    // Start is called before the first frame update
    void Start()
    {
        rigb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal"); //This is the movement for the ball
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);
        rigb.AddForce(movement * speed);
    }
     
    void OnCollisionEnter(Collision collision) //This method is checking if the player object collides with the pole object
    {
        if(collision.gameObject.tag == "Pole") 
        {
            print("Level Complete!");
        }
    }
}
