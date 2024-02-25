using UnityEngine;

public class bigbob : MonoBehaviour
{
    private Transform _transform;
    [SerializeField] private Transform _playerTransform;
    void Start()
    {
        _transform = GetComponent<Transform>();
    }

    void Update()
    {
        _transform.position = new Vector2(_playerTransform.position.x, _playerTransform.position.y);
    }
}
