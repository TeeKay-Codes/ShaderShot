using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Settings")]
    public int speed;
    public GameObject bulletPrefab;
    public GameObject bulletSpawnPoint;
    public float bulletSpeed;
    public float bulletLifetime;
    public float horizontalInput;
    public float verticalInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("A button pressed");
        }
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(-horizontalInput, 0, -verticalInput) * speed * Time.fixedDeltaTime;
        transform.Translate(movement);
        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }
    }
    void FixedUpdate()
    {
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
