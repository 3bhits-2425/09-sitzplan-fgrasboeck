using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private GameObject myParent;
    void Start()
    {
        for (int i = 0; i < 100; i++)
        {
            GameObject obj = Instantiate(prefab);
            obj.transform.SetParent(myParent.transform);
            obj.transform.localScale = myParent.transform.localScale;

        }

        }

    // Update is called once per frame
    void Update()
    {
        
    }
}
