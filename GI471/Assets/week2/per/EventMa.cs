using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventMa : MonoBehaviour
{
    Dictionary<string, UnityEvent> eventDict = new Dictionary<string, UnityEvent>();
    public static EventMa instance;
    
    void Awake ()
    {
        instance = this;
    }

    public void StartListening(string eventName , UnityAction listener)
        
    {
        if(eventDict.ContainsKey(eventName))
        {
            UnityEvent thisEvenDice = eventDict[eventName];
            thisEvenDice.AddListener(listener);
        }
        else
        {
            UnityEvent thisEvent = new UnityEvent();
            thisEvent.AddListener(listener);

            eventDict.Add(eventName, thisEvent);
        }

    }
    public void StopListening(string eventName,UnityAction listener)
    {
        if(eventDict.ContainsKey(eventName))
        {
            UnityEvent thisEvent = eventDict[eventName];
            thisEvent.RemoveListener(listener);
        }
    }
    public void TriggerEvent(string eventName)
    {
        if(eventDict.ContainsKey(eventName))
        {
            UnityEvent thisEvent = eventDict[eventName];
            thisEvent.Invoke();
        }
    }
}
