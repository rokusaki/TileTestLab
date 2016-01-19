using UnityEngine;
using System.Collections;

public class UnitStatus {

    private int Hp;
    private int Mp;
    private int Strength;
    private int Vitality;
    private int Agility;
    private int Magic;
    
    public int hp
    {
        get { return Hp; }
        set { Hp = value; }
    }

    public int mp
    {
        get { return Mp; }
        set { Mp = value; }
    }

    public int str
    {
        get { return Strength; }
        set { Strength = value; }
    }

    public int vit
    {
        get { return Vitality; }
        set { Vitality = value; }
    }

    public int agi
    {
        get { return Agility; }
        set { Agility = value; }
    }
    public int mag
    {
        get { return Magic; }
        set { Magic = value; }
    }

}
