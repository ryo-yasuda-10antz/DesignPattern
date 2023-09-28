using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

namespace Rx {
    public class ObserverTest : MonoBehaviour {
        private Subject<int> _subject;
        private PointObserver<int> _observer;

        private int count = 0;

        // Start is called before the first frame update
        void Start() {
            _subject = new Subject<int>();
            _observer = new PointObserver<int>();

            //var disposeable = _subject.Subscribe(_observer);
            var disposeable = _subject.Subscribe(x => {
                Debug.Log($"更新！ {x}");
            });
            
            _subject.OnNext(count);

        }

        //Update is called once per frame
        void Update() {
            if (Input.GetKeyDown(KeyCode.Return)) {
                count++;
                _subject.OnNext(count);
            }
        }
    }
}
