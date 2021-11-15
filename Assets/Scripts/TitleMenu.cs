using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;

public class TitleMenu : MonoBehaviour
{
    public Toggle muteToggle;
    public AudioMixer audioMixer;
    public Slider volSlider;
    public string newScene;
   // float lastVol;

    //declare Menus to enable/disable
    public GameObject TitleScreenMenu;
    public GameObject SettingsMenu;
    //public GameObject HelpMenu;
    void Start()
    {
        muteToggle.isOn = false;
        audioMixer.SetFloat("Volume", -20f);
        volSlider.value = -20;
        TitleScreenMenu.SetActive(true);
        SettingsMenu.SetActive(false);
        SettingsMenu.SetActive(false);
        //HelpMenu.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlayGame()
    {
        SceneManager.LoadScene(newScene);
    }
    public void EndGame()
    {
        Application.Quit();
    }
    public void SetVolume(float Volume)
    {
        audioMixer.SetFloat("Volume", Volume);
    }

    public void MuteVolume()
    {
        if (muteToggle.isOn)
        {
           // audioMixer.g;
            audioMixer.SetFloat("Volume", -80f);
            volSlider.value = -80;

        }
        else
        {
            audioMixer.SetFloat("Volume", -40f);
            volSlider.value = -40;
        }
    }
}