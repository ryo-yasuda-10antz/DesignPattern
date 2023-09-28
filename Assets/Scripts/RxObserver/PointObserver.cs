using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

namespace Rx {
    public class PointObserver<T> : IObserver<T> {
        public void OnCompleted() {
            Debug.Log($"完了");
        }

        public void OnError(Exception error) {
           Debug.Log($"error: {error}");
        }

        public void OnNext(T value) {
            Debug.Log($"値が変更された: {value}");
        }
    }
}