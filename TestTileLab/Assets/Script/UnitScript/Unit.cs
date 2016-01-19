using UnityEngine;
using System.Collections;

public class Unit : MonoBehaviour {

    public IDamagable unitType;
    public Player player;
    public Enemy enemy;
    public UnitStatus unitStatus;

    void Awake()
    {
        player = new Player(this);
        
    }

    void Start()
    {
        unitType = player;

    }

    public Unit()
    {


    }
}
