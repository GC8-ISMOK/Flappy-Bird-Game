using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class partic : MonoBehaviour
{
    private Transform _particleSystemTransform;
    [SerializeField] private Transform _gameObjectTransform;
    private ParticleSystem _particleSystem;
    void Start()
    {
        _particleSystemTransform = GetComponent<Transform>();
        _particleSystem = GetComponent<ParticleSystem>();
        _particleSystem.Play();
    }

    // Update is called once per frame
    void Update()
    {
        _particleSystemTransform.position = new Vector2(_gameObjectTransform.position.x, _gameObjectTransform.position.y);
    }
}
