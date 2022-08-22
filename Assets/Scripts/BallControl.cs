using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    public float speed = 20f;

    private Rigidbody2D _rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        Invoke("GoBall", 2); // Wait for 2 seconds before starting the game
    }

    public void GoBall()
    {
        float rand = Random.Range(0, 2);
        if (rand < 1)
        {
            _rigidbody.AddForce(new Vector2(speed, -15));
        }
        else
        {
            _rigidbody.AddForce(new Vector2(-speed, -15));
        }
    }

    public void ResetBall()
    {
        _rigidbody.velocity = Vector2.zero;
        transform.position = Vector2.zero;
    }

    public void RestartGame()
    {
        ResetBall();
        Invoke("GoBall", 1); // Wait for 1 second before starting the game
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.collider.CompareTag("Player"))
        {
            Vector2 velocity;
            velocity.x = _rigidbody.velocity.x;
            velocity.y = (_rigidbody.velocity.y / 2) + (coll.collider.attachedRigidbody.velocity.y / 3);
            _rigidbody.velocity = velocity;
        }
    }
}