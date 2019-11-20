using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndSpot : MonoBehaviour
{
    public GameObject finishUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        finishUI.SetActive(true); 
    }
}
