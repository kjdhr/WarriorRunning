using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioMixer mixer;
    [SerializeField] private Slider     bgmSlider;
    [SerializeField] private Slider     masterSlider;
    [SerializeField] private Slider     sfxSlider;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("bgmVolume"))
            LoadVolume();
        else
        {
            SetSFX();
            SetMaster();
            LoadVolume();
        }
    }

    //볼륨 조절 슬라이더 함수
    public void SetBGM()
    {
        float volume = bgmSlider.value;
        mixer.SetFloat("BGM", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("bgmVolume", volume);
    }

    public void SetSFX()
    {
        float volume = sfxSlider.value;
        mixer.SetFloat("SE", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("sfxVolume", volume);
    }

    public void SetMaster()
    {
        float volume = masterSlider.value;
        mixer.SetFloat("Master", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("masterVolume", volume);
    }
    private void LoadVolume()
    {
        bgmSlider.value = PlayerPrefs.GetFloat("bgmVolume");
        sfxSlider.value = PlayerPrefs.GetFloat("sfxVolume");
        masterSlider.value = PlayerPrefs.GetFloat("masterVolume");

        SetSFX();
        SetMaster();
        SetBGM();
    }
}
