using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    float speedX, speedY;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        //stealing the players rigidbody
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //move up and down
        speedX = Input.GetAxisRaw("Horizontal") * moveSpeed;
        //move left and right
        speedY = Input.GetAxisRaw("Vertical") * moveSpeed;
        //speed of movement
        rb.linearVelocity = new Vector2(speedX, speedY);

    }
}

