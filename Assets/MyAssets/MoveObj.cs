using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObj : MonoBehaviour
{
    [SerializeField] private float gravity = 0.2f;
    [SerializeField] private float power = 1.0f;
    [SerializeField] private float stopPower = 1.0f;
    // Start is called before the first frame update
    public float nowPower;
    private State state = null;
    public float wh;
    void Start()
    {
        nowPower = 0.0f;
        state = this.gameObject.AddComponent<State>();
    }

    // Update is called once per frame
    void Update()
    {
        if (state.CompareState(State.StateType.Play))
        {
            // èdóÕÇÃèàóù
            if (nowPower < 0.0f)
            {
                nowPower += gravity * 0.1f;
                if (nowPower >= 0.0f)
                {
                    nowPower = 0.0f;
                }
            }
            mouseScroll();
        }
        
    }

    public void mouseScroll()
    {
        this.wh = Input.mouseScrollDelta.y;
        Debug.Log(this.wh);
        if (this.wh < 0)
        {
            nowPower += power * this.wh;
        }
        else
        {
            nowPower += stopPower * this.wh;
            if (nowPower > 0.0f)
            {
                nowPower = 0.0f;
            }
        }

        this.transform.Translate(0.0f, Time.deltaTime * nowPower, 0.0f);
    }
}
