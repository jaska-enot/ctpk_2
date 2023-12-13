using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ChelikController : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    private Animator _animator;
    private const string HorizontalAxisName = "Horizontal";
    private float _hAxisValue;
    private static readonly int Speed = Animator.StringToHash("speed");
    private static readonly int isDown = Animator.StringToHash("isDown");


    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame

    private void Update()
    {
        _hAxisValue = Input.GetAxis(HorizontalAxisName);
        _animator.SetInteger(Speed, (int)_hAxisValue);
        _rigidbody.AddForce(new Vector2(_hAxisValue*2, 0.0f));

            
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rigidbody.AddForce(new Vector2(0.0f, 10.0f));

        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            _animator.SetBool(isDown,true);

        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            _animator.SetBool(isDown,false);

        }

    }

    private void FixedUpdate()
    {

    }
}
