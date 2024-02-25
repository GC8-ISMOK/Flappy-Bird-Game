using UnityEngine;
using UnityEngine.UI;


public class win_dead : MonoBehaviour
{   
    public Animator _cameraShake;        
    private Rigidbody2D rb;
    [SerializeField] private ParticleSystem part;
    [SerializeField] private ParticleSystem part2;

    [SerializeField] private Text winText;
    [SerializeField] public Button btn1;
    [SerializeField] public Button btn2;
     
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        part.Pause();

        part.gameObject.SetActive(false);
        btn1.gameObject.SetActive(false);
        btn2.gameObject.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            gameOver();
        }
    }
    void gameOver()
    {
        
        part.gameObject.SetActive(true);
        part.Play();
        _cameraShake.SetTrigger("shake");
        gameObject.SetActive(false);
        rb.bodyType = RigidbodyType2D.Static;
        winText.text = "game over";
        part2.gameObject.SetActive(false);
        btn1.gameObject.SetActive(true);
        btn2.gameObject.SetActive(true);
    }

}
