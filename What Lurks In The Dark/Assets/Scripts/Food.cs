using UnityEngine;

public class Food : MonoBehaviour
{
    public int value;
    [SerializeField] public AudioSource _AudioSource;
    [SerializeField] public AudioClip _cartoonChompSoundEffect;
    

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Duncan"))
        {
            Debug.Log("among us");
            _AudioSource.PlayOneShot(_cartoonChompSoundEffect);
            Destroy(gameObject);
            
            
        }
    }

}
