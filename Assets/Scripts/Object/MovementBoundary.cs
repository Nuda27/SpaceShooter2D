using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Moveable))]
public class MovementBoundary : MonoBehaviour
{
    public Rect boundary;
    private Moveable moveable;

    void Awake()
    {
        moveable = GetComponent<Moveable>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isXOutBoundary())
        {
            moveable.setXDirection(0f);
        }
        if(isYOutBoundary())
        {
            moveable.setYDirection(0f);
        }
    }

    private bool isXOutBoundary()
    {
        return moveable.getNextPosition().x < boundary.xMin || moveable.getNextPosition().x > boundary.xMax;
    }

    private bool isYOutBoundary()
    {
        return moveable.getNextPosition().y < boundary.yMin || moveable.getNextPosition().y > boundary.yMax;
    }
}
