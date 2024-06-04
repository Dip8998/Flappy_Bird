using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    [SerializeField] private float _birdSpeed, _rotationSpeed;
    [SerializeField] private AudioClip _flap , _hit , _die;
    
    private AudioSource _source;
    private Rigidbody2D _rb;
    

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _source = GetComponent<AudioSource>();
        // Start position = new vector(0,0,0)
        transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        // Give the axis for mouse and keyboard
        if(Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            // apply force to upaward via velocity
            _rb.AddForce(_rb.velocity = Vector2.up * _birdSpeed);

            // Play the flap sound
            _source.clip = _flap;
            _source.Play();       
        }
    }

    private void FixedUpdate()
    {
        // Give the rotation to bird
        transform.rotation = Quaternion.Euler(0,0,_rb.velocity.y * _rotationSpeed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    { // display the game over screen
        GameManager.Instance.GameOver();

        // play hit sound when ever bird collide somthing
        _source.clip = _hit;
        _source.Play(); 
    }
}
