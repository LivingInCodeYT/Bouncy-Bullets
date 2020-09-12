using UnityEngine;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour {
    public AudioMixer masterMixer;

    public void SetGraphics(int index) {
        QualitySettings.SetQualityLevel(index);
        if (index == 0) {
            //  Graphics set to HIGH
            PlayerPrefs.SetInt("effectsEnabled", 1);
        } else if (index == 1) {
            //  Graphics set to MEDIUM
            PlayerPrefs.SetInt("effectsEnabled", 1);
        } else {
            //  Graphics set to LOW
            PlayerPrefs.SetInt("effectsEnabled", 0);
        }
    }
    public void SetSFXVolume(float vol) {
        masterMixer.SetFloat("sfxvol", vol);
    }
    public void SetMusicVolume(float vol) {
        masterMixer.SetFloat("musicvol", vol);
    }
}