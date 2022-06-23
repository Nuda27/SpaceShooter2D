using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Moveable))]
public class MoveRandomDirection : MonoBehaviour
{
    private Moveable moveable;

    private void Awake()
    {
        moveable = GetComponent<Moveable>();
    }
    // Start is called before the first frame update
    void Start()
    {
        moveable.setDirection(randomDirection(), randomDirection());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private float randomDirection()
    {
        return Random.Range(-1f, 1);
    }
}
