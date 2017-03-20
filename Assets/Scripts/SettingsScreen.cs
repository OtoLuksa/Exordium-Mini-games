using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsScreen : MonoBehaviour
{
    public AudioSource MusicSource;
    public AudioSource SoundSource;

    public Toggle MuteToggle;
    public Slider MusicSlider;
    public Slider SoundSlider;
    public Toggle TimerToggle;
    public Dropdown TimerDropdown;

    public void Awake()
    {
        if (MusicSource != null)
        {
            if (MuteToggle != null)
            {
                MuteToggle.isOn = MusicSource.mute;
            }

            if (MusicSlider != null)
            {
                MusicSlider.value = MusicSource.volume;
            }
        }

        if ((SoundSource != null) && (SoundSlider != null))
        {
            SoundSlider.value = SoundSource.volume;
        }
    }

    public void MuteAllAudio(bool setting)
    {
        if (MusicSource != null)
        {
            MusicSource.mute = setting;
        }

        if (SoundSource != null)
        {
            SoundSource.mute = setting;
        }
    }

    public void SetMusicVolume(float value)
    {
        MusicSource.volume = value;
    }

    public void SetSoundVolume(float value)
    {
        SoundSource.volume = value;
    }
}
