using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bigbob : MonoBehaviour
{
    private Transform tf;
    [SerializeField] private Transform player_tf;
    void Start()
    {
        tf = GetComponent<Transform>();
    }

    void Update()
    {
        tf.position = new Vector2(player_tf.position.x, player_tf.position.y);
    }
}
