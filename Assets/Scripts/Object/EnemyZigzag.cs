using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Moveable))]
public class EnemyZigzag : MonoBehaviour
{
    public float frequency;
    public float magnitude;
    public float speed;

    Vector3 position;
    Vector3 axis;

    // Start is called before the first frame update
    void Start()
    {
        position = transform.position;
        axis = transform.right;
    }

    // Update is called once per frame
    void Update()
    {
        position += Vector3.down * Time.deltaTime * speed;
        transform.position = position + axis * Mathf.Sin(Time.time * frequency) * magnitude; 
    }
}