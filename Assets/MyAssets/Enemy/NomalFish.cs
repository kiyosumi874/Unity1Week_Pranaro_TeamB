using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NomalFish : MonoBehaviour
{
    [SerializeField] private float _Speed;
    int direction;
    // Start is called before the first frame update
    void Start()
    {
        this.direction = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -2.5f)
            this.direction = 1;
        if (transform.position.x > 2.5f)
            this.direction = -1;
        transform.Translate(_Speed * Time.deltaTime * this.direction, 0.0f, 0.0f);
    }
}
