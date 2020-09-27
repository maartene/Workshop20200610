using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    public int height = 10;
    public int width = 10;
    public GameObject tilePrefab;
    public float minTimeBetweenTiles = 5f;
    public float maxTimeBetweenTiles = 8f;

    List<GameObject> tiles = new List<GameObject>();

    float timer = 3;

    // Start is called before the first frame update
    void Start()
    {
        CreateLevel();
    }

    void CreateLevel()
    {
        for (int z = -height / 2; z < height / 2; z++)
        {
            for (int x = -width / 2; x < width / 2; x++)
            {
                GameObject newTile = Instantiate(tilePrefab, this.transform) as GameObject;
                newTile.transform.position = new Vector3(2f * x, 0, 2f * z);
                tiles.Add(newTile);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if (timer < 0)
        {
            StartCoroutine("MoveTileUp");
            timer = Random.Range(minTimeBetweenTiles, maxTimeBetweenTiles);
        }
    }

    IEnumerator MoveTileUp()
    {
        // select a tile
        GameObject tile = tiles[Random.Range(0, tiles.Count)];
        tiles.Remove(tile);

        Vector3 originalPosition = tile.transform.position;
        Vector3 targetPosition = originalPosition + Vector3.up * 4;

        float duration = 1;
        float t = 0;
        while (t < duration)
        {
            tile.transform.position = Vector3.Lerp(originalPosition, targetPosition, t / duration);
            t += Time.deltaTime;
            yield return null;
        }

        tile.transform.position = targetPosition;
        tile.GetComponentInChildren<GibOnCollisionEnter>().armed = true;
    }
}
