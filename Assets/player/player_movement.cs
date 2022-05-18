using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// if you want to change the location of the player game object, then you need to get access to the transform 
// component of the object

public class player_movement : MonoBehaviour { 

    public Transform transform;
    public float speed = 15;
    public float horizontal_movement;
    public float vertical_movement;
    public Vector2 movement_direction;



    // Start is called before the first frame update
    void Start()
    {
        transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal_movement = Input.GetAxisRaw("Horizontal");
        vertical_movement = Input.GetAxisRaw("Vertical");
        movement_direction = new Vector3(horizontal_movement, vertical_movement, 0);
        movement_direction.Normalize();
        transform.Translate(movement_direction * speed * Time.deltaTime);

    }

    // check the hor and ver movement in each update call and update animations accordingly. 
}
