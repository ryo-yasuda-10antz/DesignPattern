using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotifySingleton : SingletonMono<NotifySingleton> {
    public NotificationObject<int> count;

    protected override void Awake() {
        base.Awake();
        count = new NotificationObject<int>(0);
    }

    // Start is called before the first frame update
    void Start() {
       
    }

    // Update is called once per frame
    void Update() { }
}
