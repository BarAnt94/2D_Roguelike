using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    public string SceneName; 
    public void ChangeScene()
    {
        SceneManager.LoadScene(SceneName);
    }
    
}
