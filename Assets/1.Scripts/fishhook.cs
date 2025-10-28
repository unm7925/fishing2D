
using System.Transactions;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;

public class fishhook : MonoBehaviour
{
    public GameObject fishFake;
    public Transform tPos;
    public GameObject et;

    float timeToCatch = 0;
    int fishDisplayTime = 3;

    bool isFishing = false;

    GameObject currentFishing;
    GameObject fishGo;
    public GameObject rewardFish;
    public FishData availableFish;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isFishing == true)
        {
            timeToCatch += Time.deltaTime;
        }
    }

    void OnFishing()
    {
        if (isFishing == true && timeToCatch < 3f)
        {
            Destroy(currentFishing);
            isFishing = false;
        }
        else if (isFishing == true && timeToCatch > 3f)
        {
            fishGo = Instantiate(rewardFish, tPos.position, Quaternion.identity, et.transform);
            SpriteRenderer fishRenderer = fishGo.GetComponent<SpriteRenderer>();
            if (fishRenderer != null)
            {
                int randomIndex = Random.Range(0, availableFish.fishSprites.Length - 1);
                fishRenderer.sprite = availableFish.fishSprites[randomIndex];
            }
            else
            {
                Debug.Log("Error");
            }
            Destroy(fishGo, fishDisplayTime);
            Destroy(currentFishing);
            isFishing = false;
            timeToCatch = 0;
        }
        else
        {
            currentFishing = Instantiate(fishFake, tPos.position, Quaternion.identity, et.transform);
            isFishing = true;
        }
    }
}
