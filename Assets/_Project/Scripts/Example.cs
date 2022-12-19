using UnityEngine;

public class Example : ActionObject
{
    public float Speed = 5;

    void Update()
    {
        if (!IsAction) return;
        transform.position += Vector3.right * Speed * Time.deltaTime;
    }
}
