﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ManagerUS2 : MonoBehaviour {

    [SerializeField] Animator doorAnim;
    [SerializeField] AudioClip knobSound;
    [SerializeField] AudioClip doorOpenSound;


    void Start () {
		
	}


    public void B_OpenDoor()
    {
        doorAnim.SetBool("OpenDoor", true);
        AudioSource.PlayClipAtPoint(knobSound, Camera.main.transform.position);
        float animDelay = 1f;
        Invoke("PlayDoorOpenSound", knobSound.length + animDelay);
    }


    public void PlayDoorOpenSound()
    {
        AudioSource.PlayClipAtPoint(doorOpenSound, Camera.main.transform.position);
    }

}
