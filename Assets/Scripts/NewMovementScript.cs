using UnityEditor;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class NewMovementScript : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject bulletSpawnPoint;
    public float bulletSpeed;
    public float bulletLifetime;
    public float speed = 2f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        rb.freezeRotation = true;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }
    }
    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(-horizontalInput, 0f, -verticalInput);
        rb.MovePosition(rb.position + movement);

        if (movement.magnitude > 1f)
        {
            movement.Normalize();
        }

        rb.linearVelocity = new Vector3(movement.x * speed, rb.linearVelocity.y, movement.z * speed);
    }
    void Fire()
    {
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.transform.position, bulletSpawnPoint.transform.rotation);
        Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
        if (bulletRb != null)
        {
            bulletRb.linearVelocity = transform.forward * bulletSpeed;
        }
        Destroy(bullet, bulletLifetime);
    }
}
