using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public KeyCode moveUp = KeyCode.W;
    public KeyCode moveDown = KeyCode.S;
    public float speed = 10.0f;
    public float boundY = 3.75f;
    private Rigidbody2D _rigidRigidbody;

    // Start is called before the first frame update
    private void Start()
    {
        _rigidRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        MoveOnPlayerKey();
        BoundToArena();
    }


    private void MoveOnPlayerKey()
    {
        Vector2 velocity = _rigidRigidbody.velocity;
        if (Input.GetKey(moveUp))
        {
            velocity.y = speed;
        }
        else if (Input.GetKey(moveDown))
        {
            velocity.y = -speed;
        }
        else
        {
            velocity.y = 0;
        }

        _rigidRigidbody.velocity = velocity;
    }

    private void BoundToArena()
    {
        Vector3 position = transform.position;
        if (position.y > boundY)
        {
            position.y = boundY;
        }
        else if (position.y < -boundY)
        {
            position.y = -boundY;
        }

        transform.position = position;
    }
}