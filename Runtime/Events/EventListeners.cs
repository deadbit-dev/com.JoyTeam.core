using System;
using System.Collections;
using System.Collections.Generic;


namespace JoyTeam.Core.Events
{
    public delegate void EventHandler<EventType>(ref EventType eventData) where EventType : IEvent;

    public sealed class EventListeners<EventType> where EventType : IEvent
    {
        public static EventListeners<EventType> Instance { get; private set; }

        public static void AddListener(EventHandler<EventType> handler) => _listeners.Add(handler);

        public static void RemoveListener(EventHandler<EventType> handler)
        {
            _listeners.RemoveAll(listener => listener == handler);
        }

        public static List<EventHandler<EventType>> GetListeners()
        {
            return _listeners;
        }

        private readonly static List<EventHandler<EventType>> _listeners = new List<EventHandler<EventType>>();
    }
}
