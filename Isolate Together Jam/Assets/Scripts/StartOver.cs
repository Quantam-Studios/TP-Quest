using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class StartOver : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene("Game");
    }
}
