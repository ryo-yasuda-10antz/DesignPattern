using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace My {
    public class MySubject<T> : IDisposable {

        private List<IMyObserver<T>> _observers = new List<IMyObserver<T>>();

        public void RegisterObserver(IMyObserver<T> observer) {
            _observers.Add(observer);
        }

        public void UnRegisterObserver(IMyObserver<T> observer) {
            _observers.Remove(observer);
        }

        public void SendMessage(T value) {
            foreach (var myObserver in _observers) {
                myObserver.OnReceived(value);
            }
        }

        public void Dispose() {
            _observers.Clear();
        }
    }
}
