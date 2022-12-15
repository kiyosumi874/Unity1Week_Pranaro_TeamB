using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    private State state = null;
    private Vector2 initPos;
    private float axisPos;
    // Start is called before the first frame update
    void Start()
    {
        Init();
        axisPos = this.transform.position.y;
        state = this.gameObject.AddComponent<State>();
    }

    // Update is called once per frame
    void Update()
    {
        if (state.CompareState(State.StateType.Play))
        {
            var pos = this.transform.position;
            if (pos.y < initPos.y - 24.0f - axisPos)
            {
                Init();
                this.transform.position += new Vector3(0.0f, 48.0f);
            }
        }
        
    }

    private void Init()
    {
        initPos = this.transform.position;
    }
}
