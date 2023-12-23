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

    public (string, int) RandomLabelGenerator()
    {
        int randomNum = Random.Range(0, NumLabels);
        string label = "";
        Debug.Log("ランダム生成された数字" + randomNum);
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
        Debug.Log("ランダム生成されたラベル" + label);
        return (label, randomNum);
    }


}
