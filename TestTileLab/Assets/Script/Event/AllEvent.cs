using UnityEngine;
using System.Collections;

public class MoveEvent : GameEvent {

    public GameObject moveObject;
    public Transform targetTile;
    public float speed;

    public MoveEvent(GameObject moveObject , Transform targetTile , float speed)
    {
        this.moveObject = moveObject;
        this.targetTile = targetTile;
        this.speed = speed;
    }

}

public class TakeDamageEvent : GameEvent
{

    public Unit receiver;
    public Unit attacker;
    public int damage;

    public TakeDamageEvent(Unit receiver, Unit attacker, int damage)
    {
        this.receiver = receiver;
        this.attacker = attacker;
        this.damage = damage;
    }

}
