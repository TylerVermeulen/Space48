using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float rotationSpeed = 25f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Rotate();
    }
    void Move()
    {

        transform.position = transform.position + transform.forward * moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime;

    }
    void Rotate()
    {
        transform.Rotate(transform.up * rotationSpeed * Time.deltaTime * Input.GetAxis("Horizontal"));
    }
}
