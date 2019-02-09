using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTrigger : MonoBehaviour
{
    public Dialog dialog;
    public GameObject player;

    public void TriggerDialog()
    {
        FindObjectOfType<DialogManager>().StartDialog(dialog);
    }

    public void Start()
    {
        player = GameObject.Find("Player");

    }

    public void Update()
    {
        if (Vector3.Distance(player.transform.position, transform.position) > 2f)
        {
            TriggerDialog();
        }
        
        if (Vector3.Distance(player.transform.position, transform.position) > 20f)
        {
            FindObjectOfType<DialogManager>().DisplayNextSentence();
        }
    }

 
}
