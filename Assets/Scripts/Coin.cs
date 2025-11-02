using UnityEngine;

public class Coin : MonoBehaviour
{
    AudioSource source;
    private Collider2D soundTrigger;
    [SerializeField] AudioClip coinSound;
    void Awake()
    {
       source = GetComponent<AudioSource>();
       soundTrigger = GetComponent<Collider2D>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            AudioSource.PlayClipAtPoint(coinSound, transform.position, 1f);
                
        }
    }
    
}
