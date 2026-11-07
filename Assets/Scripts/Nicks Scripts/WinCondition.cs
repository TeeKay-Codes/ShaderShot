using UnityEngine;
using TMPro;
public class WinCondition : MonoBehaviour
{
    public Transform parent;
    public GameObject winText;
    private bool hasWon = false;

    public AudioSource backgroundMusic;
    void Start()
    {
        backgroundMusic.volume = 0.2f;
        backgroundMusic.Play();
        winText.SetActive(false);
    }
    void Update()
    {
        if (!hasWon && parent.childCount == 0)
        {
            hasWon = true;
            winText.SetActive(true);
            Time.timeScale = 0f;
            backgroundMusic.Stop();
        }
    }
}
