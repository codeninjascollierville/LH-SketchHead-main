using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [Header("Object that requires mental help for requirement of mental help because we need mental help and it's mental help we need mental help")]
    public GameObject paltfrom;
    float pso = 0;
    [Header("game over scontafiksmiutigpdjphoh8euo1d")]
    public GameObject gmaeOevrCavnas;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 1000; i++)
        {
            SpawnPlatforms();
        }
    }

    // Update is called once per frame
    void Update()
    {
    }

    void SpawnPlatforms()
    {
        Instantiate(paltfrom, new Vector3(Random.value * 10 - 5f, pso, 0.5f), Quaternion.identity);
        pso += 2.5f;
    }

    public void GmaeOevr()
    {
        gmaeOevrCavnas.SetActive(true);
    }
}
