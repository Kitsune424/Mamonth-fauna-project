using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPages : MonoBehaviour
{
    private GameObject curPage;

    public List<GameObject> pagesPool = new List<GameObject>();
    public GameObject final; 

    public void RandomPageActive()
    {
        int rndIndex = Random.Range(0, pagesPool.Count);
        curPage = pagesPool[rndIndex];
        pagesPool.RemoveAt(rndIndex);
        curPage.SetActive(true);
    }

    public void RandomPageNext()
    {
        if (pagesPool.Count == 0)
            final.SetActive(true);

        GameObject oldPage = curPage;
        int rndIndex = Random.Range(0, pagesPool.Count);
        curPage = pagesPool[rndIndex];
        pagesPool.RemoveAt(rndIndex);
        curPage.SetActive(true);
        oldPage.SetActive(false);
    }

}
