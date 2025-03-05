using UnityEngine;

public class FoodSpawner : MonoBehaviour
{
    public Transform foodBox;
    public GameObject food;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    public void OnFoodButton()
	{
		Instantiate(food, foodBox);
        Debug.Log("cringe");
	}
 
}
