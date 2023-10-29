using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "SOscript")]
public class SOscript : ScriptableObject
{
    [TextArea(12, 16)] [SerializeField] string StoryText;
    [SerializeField] SOscript startingstate;
    [SerializeField] SOscript[] nextStates;


    public string GetStateStory()
    {
        return StoryText;



    }
    public SOscript[] GetNextStates()
    {
        return nextStates;

    }
    // transition between states



}