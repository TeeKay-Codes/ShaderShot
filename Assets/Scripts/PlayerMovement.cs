using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Settings")]
    public int speed;
    public GameObject bulletPrefab;
    public GameObject bulletSpawnPoint;
    public float bulletSpeed;
    public float bulletLifetime;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(-horizontalInput, 0, -verticalInput) * speed * Time.fixedDeltaTime;
        transform.Translate(movement);
    }
    void Fire()
    {
        if (Input.GetMouseButtonDown(0))
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
}
