using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<ActionObject> ActionObjects => GetComponentsInChildren<ActionObject>().ToList();
    void OnGUI()
    {
        if (GUI.Button(new Rect(10, 30, 200, 30), "Start"))
        {
            OnClickStart();
        }
        if (GUI.Button(new Rect(230, 30, 200, 30), "Stop"))
        {
            OnClickStop();
        }
    }

    public void OnClickStart()
    {
        foreach (ActionObject item in ActionObjects)
        {
            item.IsAction = true;
        }
    }
    
    public void OnClickStop()
    {
        foreach (ActionObject item in ActionObjects)
        {
            item.IsAction = false;
        }
    }
}
