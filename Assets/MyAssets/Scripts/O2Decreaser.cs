using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class O2Decreaser : MonoBehaviour
{
    [SerializeField] private float decreasePal = 0.1f;
    
    public float GetDecreasePal()
    {
        return decreasePal;
    }
}
