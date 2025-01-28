using UnityEngine;
using UnityEngine.UI;

public class PauseManager : MonoBehaviour
{
    [SerializeField] private GameObject pauseImage; 
    private bool isPaused = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }
    }

    void TogglePause()
    {
        isPaused = !isPaused;

        if (isPaused)
        {
            Time.timeScale = 0;
            pauseImage.SetActive(true);
            Debug.Log("Game Paused"); 
        }
        else
        {
            Time.timeScale = 1;
            pauseImage.SetActive(false);
            Debug.Log("Game Resumed");
        }
    }
}