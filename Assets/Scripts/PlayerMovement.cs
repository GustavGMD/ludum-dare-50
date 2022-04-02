using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    public float speed = 2.35f;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        var direction = Vector2.zero;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            direction.y += speed;
        }   
        if (Input.GetKey(KeyCode.DownArrow))
        {
            direction.y -= speed;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            direction.x -= speed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            direction.x += speed;
        }

        _rigidbody.velocity = direction;
    }
}
