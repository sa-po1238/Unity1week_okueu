using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LabelManager : MonoBehaviour
{
    public static LabelManager instance_LabelManager;

    private const int NumLabels = 3; // ラベル数

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        if (instance_LabelManager == null)
        {
            instance_LabelManager = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public (string placeLabel, int placeNum) RandomPlaceGenerator()
    {
        int randomNum = Random.Range(0, NumLabels);
        string label = "";
        switch (randomNum)
        {
            case 0:
                label = "ゴゴアットン";
                break;
            case 1:
                label = "リ・エモア―";
                break;
            case 2:
                label = "スガムズ";
                break;
            default:
                Debug.Log("エラー");
                break;
        }
        return (label, randomNum);
    }

    public string RandomAddressGenerator()
    {
        int[] randomNum = new int[3];
        string address = "";

        for (int i = 0; i < 3; i++)
        {
            randomNum[i] = Random.Range(0, 10);
            address += randomNum[i].ToString();

            if (i == 2)
            {
                break;
            }

            address += "-";
        }
        return (address);
    }

    public int RandomWeightGenerator()
    {
        int randomNum = Random.Range(0, 21);
        return (randomNum);
    }

    public int RandomHeightGenerator(int size)
    {
        //size = 0: 15 ~ 24
        //size = 1: 25 ~ 34

        int randomNum = 0;

        if (size == 0)
        {
            randomNum = Random.Range(15, 25);
        }
        else if (size == 1)
        {
            randomNum = Random.Range(25, 35);
        }
        else
        {
            Debug.Log("エラー");
        }

        return (randomNum);
    }




}
