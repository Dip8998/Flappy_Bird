using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _pipe;
    [SerializeField] private float _minHeight, _maxHeight;
    [SerializeField] private float _maxTimer = 1.5f;

    private float _timer;
    void Start()
    {
        Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        // if timer is greater than specified timer that time it will spwan a pipe and after that time will be zero 
        if(_timer > _maxTimer)
        {
            Spawn();
            _timer = 0;
        }

        //Increments the timer by the time elapsed since the last frame, ensuring the timer accurately reflects the passage of time. 
        _timer += Time.deltaTime;
    }

    private void Spawn()
    {
        // Random position for spawning the pipe
        Vector3 pos = transform.position + new Vector3(0,Random.Range(_minHeight,_maxHeight));

        // Instantiate object
        GameObject obj  = Instantiate(_pipe, pos, Quaternion.identity);

        // Destroy instantiate pipe after 10 second
        Destroy(obj , 10f);
    }
}
