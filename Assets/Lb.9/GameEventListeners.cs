using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class GameEventListeners : MonoBehaviour
{
    public GameEvent Event;
    public UnityEvent Response;

    private void OnEnable()
    {
        Event.Register(this);
    }
    private void OnDisable()
    {
        Event.Unregister(this);
    }

    public void OnEventRaised()
    {

    }

}