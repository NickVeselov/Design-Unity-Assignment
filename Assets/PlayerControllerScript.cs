using System.Collections;using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerScript : MonoBehaviour {

     // Use this for initialization
     public float movementForce;
     public float cellSize;

     private Rigidbody2D rb;
     private bool moving = false;
     public Vector2 remainingPathLeft;

	void Start () {
          rb = GetComponent<Rigidbody2D>();

     }
	
	// Update is called once per frame
	void Update () {
     }

     private void FixedUpdate()
     {
          GetInput();
     }

     void GetInput()
     {
          if (Input.GetKey(KeyCode.W))
          {
               rb.MovePosition(rb.position + new Vector2(0, cellSize));
          }
          if (Input.GetKey(KeyCode.S))
          {
               rb.MovePosition(rb.position + new Vector2(0, -cellSize));
          }
          if (Input.GetKey(KeyCode.A))
          {
               rb.MovePosition(rb.position + new Vector2(-cellSize, 0));
          }
          if (Input.GetKey(KeyCode.D))
          {
               rb.MovePosition(rb.position + new Vector2(cellSize, 0));
          }
          //rubbish code
          //if (Input.GetKey(KeyCode.W))
          //{
          //     rb.AddForce(new Vector2(0, -movementForce));
          //     if (!moving)
          //     {
          //          moving = true;
          //          remainingPathLeft += new Vector2(0, -cellSize);
          //     }
          //}
          //else if (Input.GetKey(KeyCode.S))
          //{
          //     rb.AddForce(new Vector2(0, movementForce));
          //     if (!moving)
          //     {
          //          remainingPathLeft += new Vector2(0, cellSize);
          //          moving = true;
          //     }
          //}
          //else if (Input.GetKey(KeyCode.A))
          //{
          //     rb.AddForce(new Vector2(-movementForce, 0));
          //     if (!moving)
          //     {
          //          moving = true;
          //          remainingPathLeft += new Vector2(-cellSize, 0);
          //     }
          //}
          //else if (Input.GetKey(KeyCode.D))
          //{ 
          //     rb.AddForce(new Vector2(movementForce, 0));
          //     if (!moving)
          //     {
          //          remainingPathLeft += new Vector2(cellSize, 0);
          //          moving = true;
          //     }
          //     else
          //          moving = true;
          //}

          //if (moving && remainingPathLeft != Vector2.zero)
          //{
          //     Vector2 prevValue = remainingPathLeft;
          //     remainingPathLeft -= rb.velocity;
          //     if (remainingPathLeft.x * prevValue.x < 0)
          //     {
          //          remainingPathLeft.x = 0;
          //          rb.AddForce(new Vector2(-rb.velocity.x, 0));
          //     }
          //     if (remainingPathLeft.y * prevValue.y < 0)
          //     {
          //          remainingPathLeft.y = 0;
          //          rb.AddForce(new Vector2(0, -rb.velocity.y));
          //     }
          //}
     }
}
