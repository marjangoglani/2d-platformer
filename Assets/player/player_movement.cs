using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// if you want to change the location of the player game object, then you need to get access to the transform 
// component of the object

public class player_movement : MonoBehaviour { 

    public Transform transform;
    public float speed = 10;
    /*public float xPos;
    public float yPos;*/

    // Start is called before the first frame update
    void Start()
    {
        /*xPos = transform.position.x;
        yPos = transform.position.y;   */               
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Horizontal"))
        {
            transform.position.x += speed * Time.deltaTime;
        }
    }
}
