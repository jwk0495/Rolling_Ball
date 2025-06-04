using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float speed = 10f;
    public Vector2 direction = Vector2.zero;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void OnMove(InputValue value)
    {
        direction = value.Get<Vector2>();
    }

    void Update()
    {
    }

    private void FixedUpdate()
    {
        rb.AddForce(new Vector3(direction.x, 0, direction.y) * speed);
    }
}