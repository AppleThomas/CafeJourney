using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class VolumeController : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] Slider slider;
    [SerializeField] TextMeshProUGUI text;

    private void Awake()
    {
        slider.value = 1;
    }

    // Update is called once per frame
    void Update()
    {
        VolumeControl1();
    }

    public void VolumeControl1()
    {
        audioSource.volume = slider.value;
        text.text = ((int)(slider.value * 100)).ToString();
    }
}
