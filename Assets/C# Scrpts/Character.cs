using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{

    public string name;
    public int health = 100;
    public int attack;
    public int defence;

    public GameObject nameTag;

    // Start is called before the first frame update
    void Awake()
    {
        //calling private function to random generate stats
        InitStats();

    }

    private void InitStats()
    {
        attack = Random.Range(5, 20);
        defence = Random.Range(5, 20);
    }

    public void UpdateName(string newName)
    {
        name = newName;
        //changing character nametag to the name variable
        nameTag.GetComponent<TextMesh>().text = name;
    }
}
