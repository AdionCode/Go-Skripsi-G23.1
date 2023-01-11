using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerStat : MonoBehaviour
{
    [SerializeField] GameObject[] hearts;

    [SerializeField] float playerHealth;
    [SerializeField] float playerScore;

    [SerializeField] int totalScore;

    public GameObject myText;

    void Start()
    {
        
    }

    void Update()
    {
        myText.GetComponent<TMP_Text>().text = playerScore.ToString() + " / " + totalScore;
              
    }

    private void GameOver()
    {
        Time.timeScale = 0;
    }

    private void addHealth()
    {
        Debug.Log("Add Health " + playerHealth);
        if (playerHealth == 1)
        {
            Debug.Log("Heart kedua");
            hearts[1].gameObject.SetActive(true);
        }
        else if (playerHealth == 2)
        {
            hearts[2].gameObject.SetActive(true);
        }
    }

    private void decreaseHealth()
    {
        if (playerHealth < 1)
        {
            hearts[0].gameObject.SetActive(false);
            GameOver();
        }
        else if (playerHealth < 2)
        {
            hearts[1].gameObject.SetActive(false);
        }
        else if (playerHealth < 3)
        {
            hearts[2].gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Health"))
        {
            addHealth();
            Destroy(collision.gameObject);
        }

        if (collision.CompareTag("Finish"))
        {
            GameOver();
        }

        if (collision.CompareTag("Enemy"))
        {
            playerHealth -= 0.5f;
            decreaseHealth();
        }

        if (collision.CompareTag("Goal"))
        {
            playerScore += 0.5f;
            Destroy(collision.gameObject);
        }
    }
}
