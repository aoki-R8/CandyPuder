using UnityEngine;
using UnityEngine.InputSystem;

public class CreateCandy : MonoBehaviour
{
    [SerializeField]
    private GameObject candyPrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
   
    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.aKey.wasPressedThisFrame) 
        {
            GameObject instantiatedCandy = Instantiate(candyPrefab);
            instantiatedCandy.transform.position = this.transform.position;
        }   
    }
}
