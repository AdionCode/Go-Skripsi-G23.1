using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OptionManager : MonoBehaviour
{
    [SerializeField] Sprite turnOnImage;
    [SerializeField] Sprite turnOffImage;

    [SerializeField] GameObject soundButton;
    [SerializeField] GameObject vibrationButton;

    [SerializeField] GameObject optionPanel;

    bool isSound;
    bool isVibration;

    private void Start()
    {
        if (optionPanel != null)
        {
            optionPanel.gameObject.SetActive(false);
        }
        GetComponent<AudioSource>().Play();
        if (soundButton != null)
        {
            if (PlayerPrefs.GetFloat("Volume") == 1)
            {
                Debug.Log("Nyala");
                soundButton.GetComponent<Image>().sprite = turnOnImage;
            } 
            else
            {
                soundButton.GetComponent<Image>().sprite = turnOffImage;
            }
        }
    }
    public void TurnSound()
    {
        if (!isSound)
        {
            isSound = true;
            soundButton.GetComponent<Image>().sprite = turnOnImage;
            PlayerPrefs.SetFloat("Volume", 1f);
            AudioListener.volume = PlayerPrefs.GetFloat("Volume");
        }
        else
        {
            isSound = false;
            soundButton.GetComponent<Image>().sprite = turnOffImage;
            PlayerPrefs.SetFloat("Volume", 0f);
            AudioListener.volume = PlayerPrefs.GetFloat("Volume");
        }
    }
    public void TurnVibration()
    {
        if (!isVibration)
        {
            isVibration = true;
            vibrationButton.GetComponent<Image>().sprite = turnOnImage;
        }
         else
        {
            isVibration = false;
            vibrationButton.GetComponent<Image>().sprite = turnOffImage;
        }
    }

    public void OpenPanel()
    {
        optionPanel.gameObject.SetActive(true);
    }

    public void ClosePanel()
    {
        optionPanel.gameObject.SetActive(false);
    }
}
