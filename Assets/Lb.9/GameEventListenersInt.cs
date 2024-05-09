using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class GameEventListenersInt : MonoBehaviour
{
    public GameEventInt Event;
    public UnityEvent<int> Response;

    private void OnEnable()
    {
        Event.Register(this);
    }
    private void OnDisable()
    {
        Event.Unregister(this);
    }

    public void OnEventRaised(int value)
    {
        Response.Invoke(value);
    }

}
