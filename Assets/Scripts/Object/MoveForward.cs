using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Moveable))]
public class MoveForward : MonoBehaviour
{
    private Moveable moveable;
    // Vector3 targetPosition;
    // public Transform target;
    // Vector3 startPosition;
    // float percentage;
    // public float speed;
    // private bool moving;

    private void Awake()
    {
        moveable = GetComponent<Moveable>();
    }
    // Start is called before the first frame update
    void Start()
    {
        //moveable.setDirection(transform.up);
    }

    // Update is called once per frame
    void Update()
    {
        moveable.setDirection(transform.up);

        // if (transform.position.x < - 4f)
        // {
        //      transform.Translate(Vector3.left * Time.deltaTime * moveable.speed);
        // }
        // if (transform.position.x > 4f)
        // {
        //      transform.Translate(Vector3.right * Time.deltaTime * moveable.speed);
        // }
    }
    
}
