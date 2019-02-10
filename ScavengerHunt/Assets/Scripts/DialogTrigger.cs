using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTrigger : MonoBehaviour
{
    public Dialog dialog;
    public GameObject player;
	public GameObject gun;
	public GameObject radio;
	public GameObject snake;
	
	//This bool will help in making sure DisplayNextSentence is not spammed
	//in update.
	//This will start as false, which will allow DisplayNextSentence to run
	//But will then be set to false
	bool landmarkOne;
	bool landmarkTwo;
	bool landmarkThree;
	bool treasure;

	//Just for a little fun: this bool will make the treasure move away
	bool isSpotted;

	

    public void TriggerDialog()
    {
        FindObjectOfType<DialogManager>().StartDialog(dialog);
    }

    public void Start()
    {
    
		TriggerDialog();
		landmarkOne = false;
		landmarkTwo = false;
		landmarkThree = false;
		isSpotted = false;


	}

    public void Update()
    {
      
        if (Vector3.Distance(player.transform.position, transform.position) < 5f)
        {
			if (landmarkOne == false)
			{
				FindObjectOfType<DialogManager>().DisplayNextSentence();
				//Setting this landmark to true not only helps stop the functoin
				//but it will also be used by landmarkTwo to determine to play its message
				landmarkOne = true;
			}
         
		}

		if (Vector3.Distance(player.transform.position, gun.transform.position) < 5f && landmarkOne == true)
		{
			
			if (landmarkTwo == false )
			{
				FindObjectOfType<DialogManager>().DisplayNextSentence();
				landmarkTwo = true;
			}
		}

		if (Vector3.Distance(player.transform.position, radio.transform.position) < 5f && landmarkTwo == true)
		{

			if (landmarkThree == false)
			{
				FindObjectOfType<DialogManager>().DisplayNextSentence();
				landmarkThree = true;
			}
		}

		if (Vector3.Distance(player.transform.position, snake.transform.position) < 5f && landmarkThree == true)
		{

			if (treasure== false)
			{
				FindObjectOfType<DialogManager>().DisplayNextSentence();
				treasure = true;
			}

			if (Input.GetKey(KeyCode.Space))
			{
				FindObjectOfType<DialogManager>().DisplayNextSentence();
				isSpotted = true;
			}

			if (isSpotted == true)
			{
				snake.transform.Translate(1, 0, 0);
			}
		}




	}


}
