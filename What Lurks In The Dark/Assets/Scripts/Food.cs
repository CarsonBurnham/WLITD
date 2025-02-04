using UnityEngine;

public class Food : MonoBehaviour
{
    public int value;
    

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("food"))
        {
            Destroy(gameObject);
            
            
        }
    }

}
