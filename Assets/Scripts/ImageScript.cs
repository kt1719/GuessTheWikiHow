using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageScript : MonoBehaviour
{
    private int prev_num = -1;
    // Start is called before the first frame update
    public SpriteCollector wikiSprites;

    public void GenerateImage()
    {
        Destroy(GameObject.Find("img"));
        int num = Random.Range(0, wikiSprites.wikiSprites.Count);
        while(num == prev_num) num = Random.Range(0, wikiSprites.wikiSprites.Count);
        prev_num = num;
        GameObject image = new GameObject();
        image.transform.SetParent(transform);
        image.name = "img";
        image.AddComponent<SpriteRenderer>();
        image.GetComponent<SpriteRenderer>().sprite = wikiSprites.wikiSprites[num];
        image.transform.position = Camera.main.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 1));
        image.transform.position = new Vector3(image.transform.position.x, image.transform.position.y, 0);
    }
}
