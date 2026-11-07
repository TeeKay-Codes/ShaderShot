using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody rb;
    private float xInput;
    private float zInput;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");

        //Debug.Log("X: " + xInput + " Z: " + zInput);
    }

    private void FixedUpdate()
    {
        Vector3 move = transform.right * xInput + transform.forward * zInput;
        move = Vector3.ClampMagnitude(move, 1f);

        Vector3 velocity = rb.linearVelocity;

        velocity.x = move.x * moveSpeed;
        velocity.z = move.z * moveSpeed;

        rb.linearVelocity = velocity;
    }
}
