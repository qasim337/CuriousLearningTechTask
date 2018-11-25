using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagerUS3 : MonoBehaviour {

    [SerializeField] GameObject[] lightBulb;
    [SerializeField] GameObject overlay;
    [SerializeField] GameObject lightBulbButton;
    [SerializeField] Sprite lightBulbOn;
    [SerializeField] Sprite lightBulbOff;
    [SerializeField] AudioClip buttonSoundOn;
    [SerializeField] AudioClip buttonSoundOff;


    Color overlayColor;
    int bulbNo = 0;

    void Start()
    {
        //Save original color of overlay
        overlayColor = overlay.GetComponent<Image>().color;
    }


    public void B_ToggleLight(bool isOn)
    {
        
        if (bulbNo < lightBulb.Length)
        {
            //Change bulb sprite
            lightBulb[bulbNo].GetComponent<Image>().sprite = lightBulbOn;
            //Change Overlay transparency
            overlayColor.a = (180 - (bulbNo+1) * 60)/255f;
            overlay.GetComponent<Image>().color = overlayColor;
            //Disable button animation
            lightBulbButton.GetComponent<Animator>().enabled = false;
            //Play Button Sound
            AudioSource.PlayClipAtPoint(buttonSoundOn, Camera.main.transform.position);
            bulbNo++;
        }
        else
        {
            bulbNo = 0;
            //Turn off all bulbs
            for(int i=0; i<lightBulb.Length; i++)
                lightBulb[i].GetComponent<Image>().sprite = lightBulbOff;
            //Change Overlay transparency
            overlayColor.a = 180f / 255f;
            overlay.GetComponent<Image>().color = overlayColor;
            //Play Button Sound
            AudioSource.PlayClipAtPoint(buttonSoundOff, Camera.main.transform.position);
        }
    }
}
