using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    public Canvas Canvas;
    public Button retryButton;

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

    private void RetryLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene()buildIndex);
    }
}
