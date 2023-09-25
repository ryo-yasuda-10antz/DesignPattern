using System;

public class NotificationObject<T> {
    public Action<T> action;
    private T data;

    public T Value {
        get => data;
        set {
            data = value;
            Notice();
        }
    }
    
    public NotificationObject(T t) {
        Value = t;
    }

    public NotificationObject() { }

    // Destructor
    ~NotificationObject() {
        Dispose();
    }
    
    private void Notice() {
        action?.Invoke(data);
    }

    public void Dispose() {
        action = null;
    }

}
