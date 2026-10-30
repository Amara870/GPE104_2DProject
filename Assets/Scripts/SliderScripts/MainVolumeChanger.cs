using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class MainVolumeChanger : MonoBehaviour
{
    public AudioMixer audioMixer;

    public Slider mainSlider;
    public Slider musicSlider;
    public Slider sfxSlider;
    public Slider enemiesSlider;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        OnMainVolumeChange();
        OnMusicVolumeChanger();
        OnSFXVolumeChanger();
        OnEnemiesVolumeChanger();

        audioMixer.SetFloat("EnemiesAudio", -25);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMainVolumeChange()
    {

        float newVolume = mainSlider.value;
        if (newVolume <= 0)
        {
            newVolume = -80;
        }
        else
        {
            newVolume = Mathf.Log10(newVolume);
            newVolume = newVolume * 20;
        }

        audioMixer.SetFloat("MainAudio", newVolume);
    }

    public void OnMusicVolumeChanger()
    {
        float newVolume = musicSlider.value;
        if(newVolume <= 0)
        {
            newVolume = -80;
        }
        else
        {
            newVolume = Mathf.Log10(newVolume);
            newVolume = newVolume * 20;
        }

        audioMixer.SetFloat("MusicAudio", newVolume);
    }

    public void OnSFXVolumeChanger()
    {
        float newVolume = sfxSlider.value;
        if (newVolume <= 0)
        {
            newVolume = -80;
        }
        else
        {
            newVolume = Mathf.Log10(newVolume);
            newVolume = newVolume * 20;
        }

        audioMixer.SetFloat("SFXAudio", newVolume);
    }

    public void OnEnemiesVolumeChanger()
    {
        float newVolume = enemiesSlider.value;
        if (newVolume <= 0)
        {
            newVolume = -80;
        }
        else
        {
            newVolume = Mathf.Log10(newVolume);
            newVolume = newVolume * 20;
        }

        audioMixer.SetFloat("EnemiesAudio", newVolume);
    }
}
