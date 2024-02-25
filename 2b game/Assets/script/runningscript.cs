using UnityEngine;

public class runningscript : MonoBehaviour
{
    private Transform _transform;
    private float _speedX = 6f;

    void Start()
    {        
        _transform = GetComponent<Transform>();
    }

    void Update()
    {

        _transform.position = new Vector2(_transform.position.x - _speedX * Time.deltaTime, _transform.position.y);
    }

}
