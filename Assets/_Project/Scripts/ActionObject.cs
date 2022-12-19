using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionObject : MonoBehaviour
{
    public bool IsAction;

    public virtual void Action()
    {
        IsAction = true;
    }
}
