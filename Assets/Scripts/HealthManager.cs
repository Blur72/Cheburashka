using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class HealthManager : MonoBehaviour
{
    [SerializeField] private GameObject berserk;
    public Image[] hearts; 
    private int maxHealth = 3;
    private int currentHealth; 

    void Start()
    {
        currentHealth = maxHealth; 
        UpdateHearts();
    }

    public void TakeDamage()
    {
        if (currentHealth > 0)
        {
            currentHealth--;
            UpdateHearts();
        }

        if (currentHealth <= 1)
        {
            berserk.SetActive(true);
        }
        if (currentHealth <= 0)
        {
            Debug.Log("Game Over!");
            RestartGame(); 
        }
    }

    void UpdateHearts()
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            hearts[i].enabled = i < currentHealth;
        }
    }

    void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
    }
}