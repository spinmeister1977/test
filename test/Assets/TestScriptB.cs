using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScriptB : MonoBehaviour
{

    public string message1;
    public string message2;
    public string message3;

    public int messageChoice;

    public string[] messages; 


   


    // Start is called before the first frame update
    void Start()
    {

        //messageChoice = Random.Range(1, 4);
        /*
        if (messageChoice == 1)

        {
            Debug.Log(messages[0]);

        }
        else if (messageChoice == 2)
        {
            Debug.Log(messages[1]);
        }
        else if (messageChoice == 3)
        {
            Debug.Log(messages[2]);
        }
        else
        {
            Debug.Log("invalid message choice");
        }
        */
   
   

        if (messageChoice <= messages.Length - 1 && messageChoice >= 0)
        {
            Debug.Log(messages[messageChoice]);
        }
        else
        {
            Debug.Log("why are you cringe");


        }

    }   
    // Update is called once per frame
    void Update()
    {
    
    }
}
