
using UnityEngine;

public class LoaderMainScene : MonoBehaviour
{
    
    private void Start()
    {
        Loader.Load(Loader.Scene.GameScene);
        Debug.Log("peanits");
    }
}
