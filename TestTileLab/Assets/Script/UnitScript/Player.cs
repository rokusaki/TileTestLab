using UnityEngine;
using System.Collections;

public class Player : Unit , IDamagable {

    private Unit unit;

	public Player(Unit unit)
    {
        this.unit = unit;
    }

    public void TakeDamage(int damage)
    {


    }

    public int DoDamage()
    {
        int damage = 0;

        return damage;

    }
}
