using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerEndGame : MonoBehaviour {
    public string endGameScene = "";

    private void OnTriggerEnter2D (Collider2D other) {
        if (other.gameObject.tag == "Ball") {
            SceneManager.LoadScene(endGameScene);
        }
    }
}