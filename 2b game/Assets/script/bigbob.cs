using UnityEngine;

public class particlefollowplayer : MonoBehaviour
{
    private Transform _particleSystemTransform;
    private ParticleSystem _particleSystem;
    [SerializeField] private Transform _gameObjectTransform;
    void Start()
    {
        _particleSystemTransform = GetComponent<Transform>();
        _particleSystem = GetComponent<ParticleSystem>();
        _particleSystem.Play();
    }

    void Update()
    {
        _particleSystemTransform.position = new Vector2(_gameObjectTransform.position.x, _gameObjectTransform.position.y);
    }
}
