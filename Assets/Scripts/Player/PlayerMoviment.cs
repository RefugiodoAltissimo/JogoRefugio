using UnityEngine;

public class move : MonoBehaviour
{
    public float Speed = 3.5f;

    private Rigidbody2D _rb;

    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {

        Vector2 movementVector = Vector2.zero;

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) movementVector.x = -1;
        else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) movementVector.x = 1;

        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)) movementVector.y = 1;
        else if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S)) movementVector.y = -1;
        _rb.linearVelocity = movementVector * Speed;
    }

    public void SetPosition(Vector3 position)
    {
        transform.position = position;
    }
}
