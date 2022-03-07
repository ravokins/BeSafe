using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{  //
    public float playerSpeed;
    private Rigidbody2D body;
    private Vector2 playerDirection;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float directionY = Input.GetAxis("Vertical");
        playerDirection = new Vector2(0, directionY).normalized;
        
    }
    private void FixedUpdate()
    {
        body.velocity = new Vector2(0, playerDirection.y * playerSpeed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            Destroy(gameObject);

        }
    }

}
