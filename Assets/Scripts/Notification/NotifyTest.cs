using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotifyTest : MonoBehaviour {
    private NotificationObject<int> count;
    
    // Start is called before the first frame update
    void Start() {
        count = new NotificationObject<int>(0);
        count.action = CountUp;
        
        // singleton
        NotifySingleton.Instance.count.action = CountUp;
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Return)) {
            count.Value++;

            // singleton
            NotifySingleton.Instance.count.Value++;
        }
    }

    private void CountUp(int num) {
        Debug.Log($"count up!:{num}");
    }
}
