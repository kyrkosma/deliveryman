using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 200;
    [SerializeField] float moveSpeed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Time.deltaTime will help the experience be frame rate independent so that it behaves the same in a slow and fast computer
        float steerAmount = - Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        
        

        transform.Translate(0, moveAmount, 0);
        transform.Rotate(0, 0, steerAmount);
        
    }
}
