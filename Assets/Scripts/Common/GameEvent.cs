using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class GameEvent : ScriptableObject
{
    private List<GameEventListener> _gameEventListener = new List<GameEventListener>();

    public void Notify(object sender, params object[] args)
    {
        for (int i = 0; i < _gameEventListener.Count; i++)
        {
            _gameEventListener[i].OnEventNotified(sender, args);
        }
    }

    public void RegisterListener(GameEventListener listener)
    {
        if (!_gameEventListener.Contains(listener))
        {
            _gameEventListener.Add(listener);
        }
    }

    public void UnRegisterListener(GameEventListener listener)
    {
        if (_gameEventListener.Contains(listener))
        {
            _gameEventListener.Remove(listener);
        }
    }
}