using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMyObserver<T> {
     void OnReceived(T value);

}
