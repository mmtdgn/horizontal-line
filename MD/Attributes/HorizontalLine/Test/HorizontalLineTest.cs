using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalLineTest : MonoBehaviour
{
    [HorizontalLine("Float Fields", "magenta", true)]
    [SerializeField] private float m_Float_1;
    [SerializeField] private float m_Float_2;
    [SerializeField] private float m_Float3;

    [HorizontalLine("Int Fields", "yellow", true)]
    [SerializeField] private int m_Integer_1;
    [SerializeField] private int m_Integer_2;
    [SerializeField] private int m_Integer_3;

    [HorizontalLine("String Fields", "Cyan", true)]
    [SerializeField] private string m_String_1;
    [SerializeField] private string m_String_2;
    [SerializeField] private string m_String_3;

    [HorizontalLine("Vector3 Fields", "GREEN", true)]
    [SerializeField] private Vector3 m_Vector3_1;
    [SerializeField] private Vector3 m_Vector3_2;
    [SerializeField] private Vector3 m_Vector3_3;

    [HorizontalLine("Without Color")]
    [SerializeField] private GameObject m_GO_1;
    [SerializeField] private GameObject m_GO_2;
    //Single Line usage
    [HorizontalLine]
    [SerializeField] private Transform m_SingleLine;
    [SerializeField] private Transform m_SingleLine2;
    [HorizontalLine("", "red")]
    [SerializeField] private Transform m_ColorizedSingleLine;
    [SerializeField] private Transform m_ColorizedSingleLine2;
}
