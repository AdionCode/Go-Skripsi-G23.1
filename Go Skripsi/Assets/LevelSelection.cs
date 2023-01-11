using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class LevelSelection : MonoBehaviour
{
    [SerializeField] int level;
    [SerializeField] TMP_Text levelText;

    void Start()
    {
        levelText.text = "Level " + level.ToString();
    }

    public void loadLevel()
    {
        SceneManager.LoadScene("Level " + level.ToString());
    }
}
