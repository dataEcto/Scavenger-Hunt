using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogManager : MonoBehaviour
{

    public TextMeshProUGUI dialogText;
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
        
        sentences.Clear();

        foreach (string sentence in dialog.sentences)
        {
            sentences.Enqueue(sentence);
        }
        
        DisplayNextSentence();
        
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialog();
            return;
        }

        string sentence = sentences.Dequeue();
        
        //Displays the sentence in game
        dialogText.text = sentence;
    }

    public void EndDialog()
    {
        Debug.Log("Convo Ends");
    }
}
