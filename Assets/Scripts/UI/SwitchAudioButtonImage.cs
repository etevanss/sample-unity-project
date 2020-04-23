using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchAudioButtonImage : MonoBehaviour
{
    public GameObject soundImage;
    public GameObject noSoundImage;
    public bool status = true;
    void Start()
    {
        soundImage.SetActive(true);
        noSoundImage.SetActive(false);
    }

    public void ChangeAudioButtonImage(){
        soundImage.SetActive(!status);
        noSoundImage.SetActive(status);
        status = !status;
        if(status == true)
        {
            gameObject.GetComponent<AudioSource>().Play();
        }
        else
        {
            gameObject.GetComponent<AudioSource>().Stop();
        }
    }


}
