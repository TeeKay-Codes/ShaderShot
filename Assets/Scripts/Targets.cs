using UnityEngine;

public class Targets : MonoBehaviour
{
    public int targets = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            targets--;
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }

}
