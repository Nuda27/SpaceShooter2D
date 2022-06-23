using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveable : MonoBehaviour
{
    public float speed;
    private Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        updatePosition();
    }

    private void updatePosition()
    {
        transform.position = getNextPosition();
    }

    public Vector3 getNextPosition()
    {
        return transform.position + newPosition();
    }

    public Vector3 newPosition()
    {
        return direction * Time.deltaTime * speed;
    }

    internal void setXDirection(float v)
    {
        direction.x = v;
    }

    internal void setYDirection(float v)
    {
        direction.y = v;
    }

    public void setDirection(Vector3 value)
    {
        direction = value;
    }

    internal void setDirection(float x, float y)
    {
        direction.x = x;
        direction.y = y;
    }
    
    public void setDirection(Vector2 value)
    {
        direction.x = value.x;
        direction.y = value.y;
    }
}
