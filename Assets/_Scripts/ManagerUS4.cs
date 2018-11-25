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
            //Move the platform down
            case 1:
                platform.GetComponent<Animator>().SetTrigger("MoveDown");
                AudioSource.PlayClipAtPoint(leverSound, Camera.main.transform.position);
                AudioSource.PlayClipAtPoint(platformSound, Camera.main.transform.position);

                break;
            //Swing the platform sideways
            case 2:
                platform.GetComponent<Animator>().SetTrigger("MoveSideways");
                AudioSource.PlayClipAtPoint(leverSound, Camera.main.transform.position);
                AudioSource.PlayClipAtPoint(platformSound, Camera.main.transform.position);
                break;
            //Move the platform up 
            case 3:
                platform.GetComponent<Animator>().SetTrigger("MoveBack");
                AudioSource.PlayClipAtPoint(leverSound, Camera.main.transform.position);
                AudioSource.PlayClipAtPoint(platformSound, Camera.main.transform.position);
                leverState = 0;
                break;
            default:
                break;
        }
        //Change lever sprite
        lever.GetComponent<Image>().sprite = leverSprites[leverState];
    }

}
