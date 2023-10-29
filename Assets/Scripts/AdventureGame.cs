using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] Text textcomp;
    [SerializeField] SOscript startingstate;
 

    SOscript state;
    //int[] oddNumbers = { 1, 3, 5, 7, 9 };
    //string[] daysofweek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };  

    // Start is called before the first frame update
    void Start()
    {
        state = startingstate;
        textcomp.text = state.GetStateStory();
        //Debug.Log(oddNumbers[3]);
        //Debug.Log(daysofweek[1]);

    }   

    // Update is called once per frame
    void Update()
    {
        ManageState();  
    }

    private void ManageState()
    {
        throw new NotImplementedException();
    }
}

