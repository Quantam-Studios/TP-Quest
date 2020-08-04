using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class StartOver : MonoBehaviour
{
    public int Scene;
    public void RestartGame()
    {
        SceneManager.LoadScene(Scene);
    }
}
