using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointObserver<T> : IMyObserver<T> {
    public void OnReceived(T value) {
        Debug.Log(value.ToString());
    }
}
