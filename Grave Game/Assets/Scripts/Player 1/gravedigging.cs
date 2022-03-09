using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum GraveType
{
    lockPick,
    sequence,
    rapidclick
}

public class gravedigging : MonoBehaviour
{
    public GraveType graveType;



    public void RapidClick()
    {
       
        
    }

    public void LockPick()
    {

    }
    
    public void Sequence()
    {

    }
    public void BeginDigging()
    {

        switch (graveType)
        {
            case GraveType.lockPick:
                LockPick();
                Debug.Log("LockPick selected");
                break;

            case GraveType.sequence:
                Sequence();
                Debug.Log("sequence selected");
                break;

            case GraveType.rapidclick:
                RapidClick();
                Debug.Log("Rapidclick selected");
                break;

            default:
                Debug.Log("Type of grave not selected");
                break;
        }
       
    }
    
}
