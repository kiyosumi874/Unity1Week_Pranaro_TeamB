using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObj : MonoBehaviour
{
    [SerializeField] private float power = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float wh =Input.mouseScrollDelta.y;
        Debug.Log(wh);
        if (wh < 0)
        {
            this.transform.Translate(0.0f, Time.deltaTime * wh * power, 0.0f);
        }
    }
}
