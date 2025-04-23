using UnityEngine;

public class DuncanManager : MonoBehaviour
{
    public int EvoStage = 0;
    public float Food = 0;
    public float Happiness = 50;
    public bool CanEvolve = false;
    [SerializeField] public AudioSource _AudioSource;
    [SerializeField] public AudioClip _cartoonChompSoundEffect;


    
    void Start()
    {
        
    }

        void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Food"))
        {
            Debug.Log("among us");
            _AudioSource.PlayOneShot(_cartoonChompSoundEffect);
            Destroy(other);
            Food += 1;
            
            
        }


    }
    void Update()
    {
        
        
    }
}
