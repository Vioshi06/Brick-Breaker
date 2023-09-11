using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UIManager : MonoBehaviour
{
    int score = 0;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        if (scoreText == null)
        {
            scoreText = GetComponentInChildren<Text>();
        }

        UpdateScoreText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncrementScore()
    {
        score = score + 5;
        UpdateScoreText();
        if (score >= 100){
            SceneManager.LoadScene("WinScene");
        }
    }

    void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score.ToString();
        }
    }
}
