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

    bool isSound = false;
    bool isVibration = false;

    private void Start()
    {
        optionPanel.gameObject.SetActive(false);
    }
    public void TurnSound()
    {
        if (!isSound)
        {
            isSound = true;
            soundButton.GetComponent<Image>().sprite = turnOnImage;
        }
        else
        {
            isSound = false;
            soundButton.GetComponent<Image>().sprite = turnOffImage;
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
