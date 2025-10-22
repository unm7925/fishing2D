
using System.Transactions;
using Unity.Mathematics;
using UnityEngine;

public class fishhook : MonoBehaviour
{
    public GameObject fishFake;
    public Transform tPos;
    public GameObject et;

    bool isFishing = false;

    GameObject currentFish;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnFishing()
    {
        if (isFishing == true)
        {
            Destroy(currentFish);
            isFishing = false;
        }
        else
        {
            currentFish = Instantiate(fishFake, tPos.position, quaternion.identity, et.transform);
            isFishing = true;
        }
    }
}
