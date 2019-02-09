using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{



    //The CharacterController object is what it is. its mainly only for 3rd person and first person movement
    public CharacterController cc;
    public float speed;
    public float rotation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            cc.Move((transform.forward) * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            //* -1 is the inverse of forward
            cc.Move((transform.forward * -1) * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, 1, 0);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0,-1,0);
        }
    }
}
