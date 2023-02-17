using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//월드 타일의 현재 좌표값 보여주기 + 씬에서 개체 옮길 때마다 업데이트.

//편집모드, 플레이모드 둘 다에서 실행 가능하게 해줌
[ExecuteAlways]
public class CoordinateLabeler : MonoBehaviour
{
    TextMeshPro label;
    Vector2Int coordinates = new Vector2Int();

    void Awake() 
    {
        label = GetComponent<TextMeshPro>();
        DisplayCoordinates();
    }

    void Update()
    {
        //Application이 재생하지 않을 때(편집 모드에서 스크립트 실행)
        if(!Application.isPlaying)
        {
            DisplayCoordinates();
            UpdateObjectName();
        }
    }

    void DisplayCoordinates()
    {
        //그리드 스냅 설정으로 나눠줌.
        coordinates.x = Mathf.RoundToInt(transform.parent.position.x / UnityEditor.EditorSnapSettings.move.x);
        coordinates.y = Mathf.RoundToInt(transform.parent.position.z / UnityEditor.EditorSnapSettings.move.z);


        label.text = coordinates.x + "," + coordinates.y;
    }

    void UpdateObjectName()
    {
        transform.parent.name = coordinates.ToString();
    }
}
