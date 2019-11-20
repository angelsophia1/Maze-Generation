using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject mazePrefab,finishUI,player;
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
        finishUI.SetActive(false);
        player.transform.position = new Vector3(-9.5f,0f,9.5f);
        Destroy(mazeInstance.gameObject);
        BeginGame();
    }
}
