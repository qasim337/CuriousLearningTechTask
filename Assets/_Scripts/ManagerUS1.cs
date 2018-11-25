using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagerUS1: MonoBehaviour {


    [SerializeField] GameObject lightBulb;
    [SerializeField] GameObject overlay;
    [SerializeField] GameObject lightBulbButton;
    [SerializeField] Sprite lightBulbOn;
    [SerializeField] Sprite lightBulbOff;
    [SerializeField] AudioClip buttonSoundOn;
    [SerializeField] AudioClip buttonSoundOff;


    Color overlayColor;


    void Start () {
        //Save original color of overlay
        overlayColor = overlay.GetComponent<Image>().color;
	}
	
	
    public void B_ToggleLight(bool isOn)
    {
        if (isOn)
        {
            //Change bulb sprite
            lightBulb.GetComponent<Image>().sprite = lightBulbOn;
            //Change Overlay transparency
            overlayColor.a = 0;
            overlay.GetComponent<Image>().color = overlayColor;
            //Disable button animation
            lightBulbButton.GetComponent<Animator>().enabled = false;
            //Play Button Sound
            AudioSource.PlayClipAtPoint(buttonSoundOn, Camera.main.transform.position);
        }
        else
        {
            //Change bulb sprite
            lightBulb.GetComponent<Image>().sprite = lightBulbOff;
            //Change Overlay transparency
            overlayColor.a = 125f/255f;
            overlay.GetComponent<Image>().color = overlayColor;
            //Play Button Sound
            AudioSource.PlayClipAtPoint(buttonSoundOff, Camera.main.transform.position);
        }

    }


}
