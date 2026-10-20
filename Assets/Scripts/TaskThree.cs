using System.Collections;
using UnityEngine;

public class TaskThree : MonoBehaviour
{
    public GameObject bigScrewprefab;
    public GameObject smallScrew;
    private int currentScrews = 0; 
    public int maxCombine = 10;
    public float spawnTime = 3;

    IEnumerator SpawnCycle()
    {
        yield return new WaitForSeconds(spawnTime);
        SpawnSmalls();
        if(currentScrews < maxCombine)
        {
            StartCoroutine(SpawnCycle());
        }
    }

    private void Start()
    {
        StartCoroutine(SpawnCycle());
    }

    void SpawnSmalls()
    {
        float x = Random.Range(0f, 1f);
        float y = Random.Range(0f, 1f);
        Vector3 position = new Vector3(x, y, 1f);
        GameObject newScrew = Instantiate(smallScrew, Camera.main.ViewportToWorldPoint(position), Quaternion.identity);
        currentScrews++;
    }

    void Merge()
    {

    }
}