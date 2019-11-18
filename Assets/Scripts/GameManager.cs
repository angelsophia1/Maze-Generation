using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject mazePrefab;
    private Maze mazeInstance;
    // Start is called before the first frame update
    void Start()
    {
        BeginGame();
    }

    // Update is called once per frame
    void Update()
    {

    }


    void BeginGame()
    {
        mazeInstance = Instantiate(mazePrefab).GetComponent<Maze>();
        mazeInstance.Generate();
    }

    //Press Button Restart
    public void RestartGame()
    {
        Destroy(mazeInstance.gameObject);
        BeginGame();
    }
}
