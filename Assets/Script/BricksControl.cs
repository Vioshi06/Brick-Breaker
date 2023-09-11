using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BricksControl : MonoBehaviour
{
   public UIManager ui;

    void Start()
    {
        ui = GameObject.FindWithTag("ui").GetComponent<UIManager>();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ball")
        {
            ui.IncrementScore();
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D (Collider2D other)
    {
        
    }
}

