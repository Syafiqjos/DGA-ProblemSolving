using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    public int minTotalBlock;
    public int maxTotalBlock;
    public Rect border;
    public Block blockPrefab;
    public Transform blockParent;

    private List<Block> blockList;

    private void Start()
    {
        blockList = new List<Block>();
        SpawnBlocks();
    }

    void SpawnBlocks()
    {
        int totalBlock = Random.Range(minTotalBlock, maxTotalBlock);
        for (int i = 0;i < totalBlock;i++)
        {
            SpawnBlock(border);
        }
    }

    void SpawnBlock(Rect border)
    {
        Block ne = Instantiate(blockPrefab.gameObject).GetComponent<Block>();
        ne.Initialize(border);
        blockList.Add(ne);

        ne.transform.parent = blockParent;

    }
}
