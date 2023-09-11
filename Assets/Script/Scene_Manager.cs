using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Scene_Manager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartClicked()
    {
        SceneManager.LoadScene("LevelScene");
    }
    public void ExitClicked()
    {
        Application.Quit();
    }
    public void Level1Clicked()
    {
        SceneManager.LoadScene("Level1");
    }
    public void Level2Clicked()
    {
        SceneManager.LoadScene("Level2");
    }
    public void ReturnClicked()
    {
        SceneManager.LoadScene("LevelScene");
    }
    public void BackClicked()
    {
        SceneManager.LoadScene("MenuScene");
    }
}
