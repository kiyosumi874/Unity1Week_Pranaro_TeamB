using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magma : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _acceleration;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0.0f, _speed * Time.deltaTime, 0.0f);
        _speed *= _acceleration;
    }
}