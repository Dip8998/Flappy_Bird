using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private float _width = 10f;

    private SpriteRenderer _renderer;
    private Vector2 _size;
    void Start()
    {
        _renderer = GetComponent<SpriteRenderer>();

        // Set size of the ground
        _size = new Vector2(_renderer.size.x, _renderer.size.y);
    }

    // Update is called once per frame
    void Update()
    {
        // Render the ground while play
        _renderer.size = new Vector2(_renderer.size.x + _speed * Time.deltaTime, _renderer.size.y);

        // if reneder ground size > the ground width then renderer ground size is = _size
        if(_renderer.size.x > _width)
        {
            _renderer.size = _size;
        }
    }
}
