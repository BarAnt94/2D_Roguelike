using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    public Canvas reloadCanvas;
    public Button reloadButton;
    public Button quitButton;
    public Button retryButton;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            DiscController disc = collision.GetComponentInParent<DiscController>();
            if (disc)
            {
                // Afficher le Canvas
                reloadCanvas.gameObject.SetActive(true);

                // Activer le bouton de rechargement
                reloadButton.onClick.AddListener(ReloadLevel);

                // Activer le bouton de quitter
                quitButton.onClick.AddListener(ApplicationQuit);

                // Activer le bouton de retry
                retryButton.onClick.AddListener(RetryLevel);
            }
        }
    
    }

    private void ReloadLevel()
    {
        // Recharger le niveau actuel
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void ApplicationQuit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    private void RetryLevel()
    {
        // Recharger le niveau 1
        SceneManager.LoadScene(0); // Assurez-vous que le niveau 1 est à l'index 0
    }
}
