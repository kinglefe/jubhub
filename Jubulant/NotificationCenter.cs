using System;
using System.Collections.Generic;
namespace Jubulant
{
    public class NotificationCenter
    {
        private Dictionary<String, EventContainer> observers;
        private static NotificationCenter _instance;
        public static NotificationCenter Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new NotificationCenter();
                }
                return _instance;
            }
        }
        public NotificationCenter()
        {
            observers = new Dictionary<String, EventContainer>();
        }

        private class EventContainer
        {
            private event Action<Notification> Observer;
            public EventContainer()
            {
            }

            public void addObserver(Action<Notification> observer)
            {
                Observer += observer;
            }

            public void removeObserver(Action<Notification> observer)
            {
                Observer -= observer;
            }

            public void sendNotification(Notification notification)
            {
                Observer(notification);
            }

            public bool isEmpty()
            {
                return Observer == null;
            }
        }

        public void addObserver(String notificationName, Action<Notification> observer)
        {
            if (!observers.ContainsKey(notificationName))
            {
                observers[notificationName] = new EventContainer();
            }
            observers[notificationName].addObserver(observer);
        }

        public void removeObserver(String notificationName, Action<Notification> observer)
        {
            if (observers.ContainsKey(notificationName))
            {
                observers[notificationName].removeObserver(observer);
                if (observers[notificationName].isEmpty())
                {
                    observers.Remove(notificationName);
                }
            }
        }

        public void postNotification(Notification notification)
        {
            if (observers.ContainsKey(notification.Name))
            {
                observers[notification.Name].sendNotification(notification);
            }
        }
    }
}
