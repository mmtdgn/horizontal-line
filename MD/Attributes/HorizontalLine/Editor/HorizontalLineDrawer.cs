using UnityEngine;
using UnityEditor;

[CustomPropertyDrawer(typeof(HorizontalLine))]
public class HorizontalLineDrawer : DecoratorDrawer
{
    HorizontalLine m_HorizontalLine { get => attribute as HorizontalLine; }
    private const float OFFSET = 10.0f;
    public override void OnGUI(Rect position)
    {
        if (string.IsNullOrEmpty(m_HorizontalLine.Title))
        {
            position.height = 5;
            position.y += 10f;
            GUI.backgroundColor = m_HorizontalLine.Color;
            GUI.Box(position, string.Empty, EditorStyles.objectFieldThumb);
            GUI.backgroundColor = Color.white;
        }
        else
        {
            GUI.backgroundColor = m_HorizontalLine.Color;
            position.y += 15f;

            float _labelWidth = GuiStyle().CalcSize(new GUIContent(m_HorizontalLine.Title)).x;
            float _lineWidth = (position.width - _labelWidth) / 2f - OFFSET;

            float _LeftLine_x_Pos = position.xMin;
            float _Label_x_Pos = position.xMin + _lineWidth + OFFSET;
            float _RightLine_x_Pos = _LeftLine_x_Pos + _lineWidth + _labelWidth + 2 * OFFSET;


            Rect _LeftLineRect = new Rect(_LeftLine_x_Pos + 5f, position.yMin, _lineWidth - 5f, 5f);
            Rect _LabelRect = new Rect(_Label_x_Pos, position.yMin - 4.0f, _lineWidth, 5f);
            Rect _RightLineRect = new Rect(_RightLine_x_Pos, position.yMin, _lineWidth - 5f, 5f);
            Rect _Outline = new Rect(_Label_x_Pos - 5.0f, position.yMin - 7f, _labelWidth + 10.0f, 20f);

            GUI.Box(new Rect(position.xMin, position.yMin - 10f, position.width, position.height - 10f)
            , string.Empty, EditorStyles.helpBox);
            GUI.Box(_Outline, string.Empty, EditorStyles.objectFieldThumb);
            GUI.Box(_LeftLineRect, string.Empty, EditorStyles.objectFieldThumb);
            GUI.Label(_LabelRect, m_HorizontalLine.Title, GuiStyle());
            GUI.Box(_RightLineRect, string.Empty, EditorStyles.objectFieldThumb);

            if (!m_HorizontalLine.ColorizedField)
                GUI.backgroundColor = Color.white;
        }
    }

    private GUIStyle GuiStyle()
    {
        GUIStyle _LabelStyle = new GUIStyle()
        {
            fontStyle = FontStyle.Bold,
            fontSize = 12,
            normal =
            {
                //textColor = m_HorizontalLine.Color
                textColor = Color.white
            }
        };
        return _LabelStyle;
    }

    public override float GetHeight()
    {
        return 36.0f;
    }
}