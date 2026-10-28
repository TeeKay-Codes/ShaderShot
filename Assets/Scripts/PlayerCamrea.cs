using System.IO;
using UnityEngine;
using UnityEngine.Rendering;

public class PlayerCamrea : MonoBehaviour
{
    public float mouseSensitivity = 100f;

    private float xRotation = 0f;
    private float yRotation = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // 2. Calculate vertical (X-axis) rotation
        xRotation = Mathf.Clamp(xRotation - mouseY, -89f, 89f);
        // 3. Calculate horizontal (Y-axis) rotation
        yRotation += mouseX;

        // 4. Apply rotations directly to the camera's transform
        transform.localRotation = Quaternion.Euler(xRotation, yRotation, 0f);
    }
}
