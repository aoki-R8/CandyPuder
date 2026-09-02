using UnityEngine;
using System;
using UnityEngine.InputSystem;

public class CreateCandy : MonoBehaviour
{
    public StageOut stageout;

    [SerializeField]
    private GameObject candyPrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
   
    // Update is called once per frame
    void Update()
    {
        

       
    }

    public void OnReceiveClick()
    {
        int number = stageout.SCORE;
        
        if(number > 0)
        {
            stageout.SCORE += -1;
            stageout.SCOREText.text = $"{stageout.SCORE}";
            GameObject instantiatedCandy = Instantiate(candyPrefab);
            instantiatedCandy.transform.position = this.transform.position;
        }

        
    }
}
