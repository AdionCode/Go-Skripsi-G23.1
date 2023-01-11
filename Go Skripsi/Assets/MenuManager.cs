using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public void NewGame()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void SelectLevel()
    {
        SceneManager.LoadScene("Select Level Menu");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    
}
