using UnityEngine;
using System.Collections;

public interface IUnitState {

    void UpdateState();
    void ToCammandState();
    void ToMoveState();
    void ToActionState();
    void ToWaitState();

}

public class CammandState : IUnitState
{

    public void UpdateState()
    {


    }
    public void ToCammandState()
    {

    }

    public void ToMoveState()
    {

    }

    public void ToActionState()
    {

    }

    public void ToWaitState()
    {

    }
}
