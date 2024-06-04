using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    [SerializeField] private float _pipeSpeed;
  
    void Update()
    {
        // pipe move towards left side
        transform.position += Vector3.left * _pipeSpeed * Time.deltaTime;
    }
}
