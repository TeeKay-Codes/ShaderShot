using UnityEngine;

public class LightToggle : MonoBehaviour
{
    [SerializeField] private GameObject objectToToggle;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            ToggleObject();
        }
    }
    public void ToggleObject()
    {
        if (objectToToggle != null)
        {
            bool isActive = objectToToggle.activeSelf;
            objectToToggle.SetActive(!isActive);
        }
    }
}