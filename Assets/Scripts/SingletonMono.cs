using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SingletonMono<T> : MonoBehaviour where T : MonoBehaviour{
    private static T instance;

    public static T Instance {
        get {
            if (instance == null) {
                Type type = typeof(T);
                instance = (T)FindObjectOfType(type);
            }

            return instance;
        }
    }
    
    protected virtual void Awake() {
        if (instance == null) {
            instance = this as T;
            DontDestroyOnLoad(this);
        } else {
            Destroy(this);
        }
    }
}
