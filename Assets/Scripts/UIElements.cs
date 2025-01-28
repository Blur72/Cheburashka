using UnityEngine;
using TMPro; 

public class UIElements : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textscore; 
    [SerializeField] private TextMeshProUGUI bestScoreText; 
    private int _score;
    private static int _bestScore; 

    void Start()
    {
        _score = 0;
        UpdateScoreText(); 
        UpdateBestScoreText();
    }

    public void CntPlusPlus()
    {
        _score += 1;
        UpdateScoreText(); 
        CheckBestScore(); 
    }

    private void UpdateScoreText() 
    {
        textscore.text = _score.ToString();
    }

    private void UpdateBestScoreText() 
    {
        bestScoreText.text = _bestScore.ToString(); 
    }

    private void CheckBestScore()
    {
        if (_score > _bestScore)
        {
            _bestScore = _score;
            UpdateBestScoreText(); 
        }
    }

    public void ResetScore() 
    {
        _score = 0;
        UpdateScoreText(); 
    }
}