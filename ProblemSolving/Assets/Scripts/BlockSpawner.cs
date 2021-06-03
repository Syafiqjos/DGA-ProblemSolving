using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    public int maxTotalBlock;
    public Rect border;
    public GameObject blockPrefab;
    public Transform blockParent;

    private List<GameObject> blockList;

    private void Start()
    {
        blockList = new List<GameObject>();
        SpawnBlocks();
    }

    void SpawnBlocks()
    {
        int totalBlock = Random.Range(0, maxTotalBlock);
        for (int i = 0;i < totalBlock;i++)
        {
            float x = Random.Range(border.x, border.x + border.width);
            float y = Random.Range(border.y, border.y + border.height);

            SpawnBlock(new Vector2(x, y));
        }
    }

    void SpawnBlock(Vector2 pos)
    {
        GameObject ne = Instantiate(blockPrefab, pos, Quaternion.identity);
        blockList.Add(ne);

        ne.transform.parent = blockParent;

    }
}
