using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public static bool GameIsPaused = false;
    public GameObject Pausemenu;

    // Start is called before the first frame update
    void Start()
    {
    GameIsPaused = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Player.GameOver == false)
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    void Resume()
    {
        Pausemenu.SetActive(false);

        GameIsPaused = false;
        Time.timeScale = 1f;
    }

    void Pause()
    {
        Pausemenu.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

public void QuitToMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);
    }
}
