using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObserverTest : MonoBehaviour {
    private MySubject<int> _subject;
    private PointObserver<int> _observer;

    private int count = 0;
    
    // Start is called before the first frame update
    void Start() {
        _subject = new MySubject<int>();
        _observer = new PointObserver<int>();
        
        _subject.RegisterObserver(_observer);
        
        _subject.SendMessage(count);
        
    }

    //Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Return)) {
            count++;
            _subject.SendMessage(count);
        }
    }
}
