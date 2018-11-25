using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ManagerUS4 : MonoBehaviour {


    [SerializeField] Sprite[] leverSprites;
    [SerializeField] GameObject lever;
    [SerializeField] GameObject platform;
    [SerializeField] AudioClip leverSound;
    [SerializeField] AudioClip platformSound;

    private int leverState = 0;

	void Start () {
		
	}

    public void B_LeverPressed()
    {
        leverState++;

        switch(leverState)
        {
            case 1:
                platform.GetComponent<Animator>().SetTrigger("MoveDown");
                AudioSource.PlayClipAtPoint(leverSound, Camera.main.transform.position);
                AudioSource.PlayClipAtPoint(platformSound, Camera.main.transform.position);

                break;
            case 2:
                platform.GetComponent<Animator>().SetTrigger("MoveSideways");
                AudioSource.PlayClipAtPoint(leverSound, Camera.main.transform.position);
                AudioSource.PlayClipAtPoint(platformSound, Camera.main.transform.position);
                break;
            case 3:
                platform.GetComponent<Animator>().SetTrigger("MoveBack");
                AudioSource.PlayClipAtPoint(leverSound, Camera.main.transform.position);
                AudioSource.PlayClipAtPoint(platformSound, Camera.main.transform.position);
                //Invoke("PlayPlatformSound", leverSound.length);
                leverState = 0;
                break;
            default:
                break;
        }
        lever.GetComponent<Image>().sprite = leverSprites[leverState];
    }


    void PlayPlatformSound()
    {
        AudioSource.PlayClipAtPoint(platformSound, Camera.main.transform.position);
    }

}
