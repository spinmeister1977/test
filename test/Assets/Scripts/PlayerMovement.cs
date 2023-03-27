using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    //referance to a Rigidbody 2d
    private Rigidbody2D physicsBody = null;
    public float jumpSpeed = 10;
    public float playerspeed = 1;
    public void MoveLeft()
    {
        Vector2 newVelocity = physicsBody.velocity;

        newVelocity.x = -playerspeed;
        physicsBody.velocity = newVelocity;
    }

    public void MoveRight()
    {
        Vector2 newVelocity = physicsBody.velocity;

        newVelocity.x = playerspeed;
        physicsBody.velocity = newVelocity;
    }

    public void Jump()
    {
        //jump speed setting
        Vector2 newVelocity = physicsBody.velocity;
        newVelocity.y = jumpSpeed;
        physicsBody.velocity = newVelocity;     
    }
    private void Awake()
    {
        physicsBody = GetComponent<Rigidbody2D>();
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
