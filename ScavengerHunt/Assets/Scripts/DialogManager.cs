using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogManager : MonoBehaviour
{
    //Like an Array, but Queue uses FIFO
    //Think in Homestuck: John's Inventory was First in, First Out
    //It was limited, but it fits for what I am trying to do.
    private Queue<string> sentences;

    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialog (Dialog dialog)
    {
        Debug.Log("Start the Convo");
    }
}
