using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class ResponseEvent : UnityEvent<object, object[]> {}
public class GameEventListener : MonoBehaviour
{
    public GameEvent gameEvent = null;
    public ResponseEvent response = null;

    private void OnEnable()
    {
        gameEvent.RegisterListener(this);
    }

    private void OnDisable()
    {
        gameEvent.UnRegisterListener(this);
    }

    public void OnEventNotified(object sender, object[] args)
    {
        response.Invoke(sender, args);
    }
}
