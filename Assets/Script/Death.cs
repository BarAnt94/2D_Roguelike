using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    public Canvas Canvas;
    public Button retryButton;
    public string SceneName;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Disc")&& gameObject.GetComponent<Dash>().isdashing == false)
        {
            // Afficher le Canvas
            Canvas.gameObject.SetActive(true);
            // Activer le bouton de retry
            retryButton.onClick.AddListener(RetryLevel);
        }
    }
    public void RetryLevel()
    {
        SceneManager.LoadScene(SceneName);
    }
}
