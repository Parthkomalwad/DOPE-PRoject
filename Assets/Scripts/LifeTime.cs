using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeTime : MonoBehaviour
{
    public float lifetime;
    
    void Update()
    {
        Destroy(gameObject, lifetime);
        
    }
}
