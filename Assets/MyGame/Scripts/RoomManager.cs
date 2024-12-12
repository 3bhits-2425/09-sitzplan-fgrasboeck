using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomManager : MonoBehaviour
{

    [SerializeField] private TableLayoutData tabelLayout;  // Ref zu TableLayout ScriptableObject
    [SerializeField] private StudentData[] students;
    [SerializeField] private GameObject tablePrefab; // Prefab für Tische
    [SerializeField] private GameObject chairPrefab; // Prefab für Stühle

    // Start is called before the first frame update
    void Start()
    {
        for (int row = 0; row < tabelLayout.rows; row++)
        {
            for (int col = 0; col < tabelLayout.columns; col++)
            {
                Vector3 tablePosition = new Vector3(col * tabelLayout.tableSpacing, 0, row * tabelLayout.tableSpacing);

                // Tische Plazieren
                GameObject table = Instantiate(tablePrefab, tablePosition, Quaternion.identity, transform);

                
                // Sessel platzieren
                Transform pos1 = table.transform.Find("pos1");
                Transform pos2 = table.transform.Find("pos2");
                GameObject rightChair = Instantiate(chairPrefab, pos1.position, Quaternion.Euler(0,90,0), transform);
                GameObject leftChair = Instantiate(chairPrefab, pos2.position, Quaternion.Euler(0,90,0), transform);
               
            }


        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}