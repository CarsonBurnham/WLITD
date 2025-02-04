using UnityEngine;

public class Food : MonoBehaviour
{
    public int value;
    [SerializeField] public AudioSource _as;
    [SerializeField] public AudioClip _cartoonChompSoundEffect;
    

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Duncan"))
        {
            _as.PlayOneShot(_cartoonChompSoundEffect);
            Destroy(gameObject);
            
            
        }
    }

}
