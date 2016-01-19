using UnityEngine;
using System.Collections;

public class MoveEventHandler {

	public void SetupListener()
    {
        EventManager.Instance.AddListener<MoveEvent>(OnMoveEvent);
    }

    public void SetupListenerOnce()
    {
        EventManager.Instance.AddListenerOnce<MoveEvent>(OnMoveEvent);
    }

    public void Dispose()
    {
        EventManager.Instance.RemoveListener<MoveEvent>(OnMoveEvent);

    }

    void OnMoveEvent( MoveEvent e)
    {

    }
}

public class TakeDamageEventHandler
{

    public void SetupListener()
    {
        EventManager.Instance.AddListener<TakeDamageEvent>(OnTakeDamageEvent);
    }

    public void SetupListenerOnce()
    {
        EventManager.Instance.AddListenerOnce<TakeDamageEvent>(OnTakeDamageEvent);
    }

    public void Dispose()
    {
        EventManager.Instance.RemoveListener<TakeDamageEvent>(OnTakeDamageEvent);

    }

    void OnTakeDamageEvent(TakeDamageEvent e)
    {
        
    }
}
