using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameEvent", menuName = "ScriptableObjects/GameEventInt", order = 2)]
public class GameEventInt : ScriptableObject
{
    List<GameEventListenersInt> listeners = new List<GameEventListenersInt>();

    public void Raise(int value)
    {
        for (int i = listeners.Count - 1; i >= 0; i--)
        {
            listeners[i].OnEventRaised(value);
        }
    }
    public void Register(GameEventListenersInt GameEventListener)
    {
        listeners.Add(GameEventListener);
    }
    public void Unregister(GameEventListenersInt GameEventListener)
    {
        listeners.Remove(GameEventListener);
    }

}
