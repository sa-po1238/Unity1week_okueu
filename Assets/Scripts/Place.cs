using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Place : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlaceLabel()
    {
        (string PlaceLabel, int placeNum) = LabelManager.instance_LabelManager.RandomPlaceGenerator();
        Debug.Log("地名" + PlaceLabel);
        Debug.Log("地名管理番号" + placeNum);
    }

    public void AddressLabel()
    {
        string AddressLabel = LabelManager.instance_LabelManager.RandomAddressGenerator();
        Debug.Log("番地" + AddressLabel);
    }
}
