using UnityEngine;

public class cumShake : MonoBehaviour
{
    public Animator camshake;

    public void Shake()
    {
        camshake.SetTrigger("shake");
    }
}
