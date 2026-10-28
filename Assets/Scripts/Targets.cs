using UnityEditor.Rendering;
using UnityEngine;
using TMPro;

public class Targets : MonoBehaviour
{
    public int targets = 5;
    public GameObject dialogueBox;
    public TextMeshProUGUI dialogueText;
    public string completionMessage = "You Win!";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (targets == 0)
        {
            TriggerDialogue();
        }
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
    private void TriggerDialogue()
    {
        if (dialogueBox != null && dialogueText != null)
        {
            dialogueText.text = completionMessage;
            dialogueBox.SetActive(true);
        }
    }

}
