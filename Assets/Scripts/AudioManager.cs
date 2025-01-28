using UnityEngine;

public class MusicManager : MonoBehaviour
{
    private AudioSource audioSource;
    private bool isPlaying = false;

    void Start()
    {
        // Получаем компонент AudioSource на этом объекте
        audioSource = GetComponent<AudioSource>();

        // Если музыка должна начинать с выключенным состоянием
        audioSource.Pause();
    }

    void Update()
    {
        // Проверяем, нажата ли клавиша Space
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ToggleMusic();
        }
    }

    private void ToggleMusic()
    {
        if (isPlaying)
        {
            audioSource.Pause(); // Останавливаем воспроизведение
        }
        else
        {
            audioSource.Play(); // Начинаем воспроизведение
        }

        // Переключаем состояние
        isPlaying = !isPlaying;
    }
}