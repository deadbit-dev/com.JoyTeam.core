using System;
using UnityEngine;


namespace JoyTeam.Core.Events
{
    public class EventBus : MonoBehaviour
    {
        public virtual void Subscribe<EventType>(EventHandler<EventType> handler) where EventType : IEvent
        {
            EventListeners<EventType>.AddListener(handler);
        }

        public virtual void Unsubscribe<EventType>(EventHandler<EventType> handler) where EventType : IEvent
        {
            EventListeners<EventType>.RemoveListener(handler);
        }

        public virtual void Emmit<EventType>(ref EventType eventData) where EventType : IEvent
        {
            foreach (var listener in EventListeners<EventType>.GetListeners())
            {
                try
                {
                    listener?.Invoke(ref eventData);
                }
                catch (Exception e)
                {
                    Debug.LogException(e);
                }
            }
        }
    }
}
