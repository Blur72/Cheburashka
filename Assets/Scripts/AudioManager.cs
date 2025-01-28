using UnityEngine;

public class MusicManager : MonoBehaviour
{
    private AudioSource audioSource;
    private bool isPlaying = false;

    void Start()
    {
        // �������� ��������� AudioSource �� ���� �������
        audioSource = GetComponent<AudioSource>();

        // ���� ������ ������ �������� � ����������� ����������
        audioSource.Pause();
    }

    void Update()
    {
        // ���������, ������ �� ������� Space
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ToggleMusic();
        }
    }

    private void ToggleMusic()
    {
        if (isPlaying)
        {
            audioSource.Pause(); // ������������� ���������������
        }
        else
        {
            audioSource.Play(); // �������� ���������������
        }

        // ����������� ���������
        isPlaying = !isPlaying;
    }
}