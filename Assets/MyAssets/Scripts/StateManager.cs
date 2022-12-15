using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> objects;

    public void SetStateAll(State.StateType state)
    {
        foreach (var item in objects)
        {
            var st = item.GetComponent<State>();
            if (st)
            {
                st.SetState(state);
            }
        }
    }
}
