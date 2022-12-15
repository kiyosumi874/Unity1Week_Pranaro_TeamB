using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State : MonoBehaviour
{
    public enum StateType
    {
        Play,
        Stop
    }
    private StateType state;

    public State()
    {
        state = StateType.Play;
    }

    public State(StateType state)
    {
        this.state = state;
    }

    public void SetState(StateType state)
    {
        this.state = state;
    }

    public StateType GetState()
    {
        return state;
    }

    public bool CompareState(StateType state)
    {
        return this.state == state;
    }
}
