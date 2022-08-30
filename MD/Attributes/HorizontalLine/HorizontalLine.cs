using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Line drawer attribute for inspector
/// </summary>
public class HorizontalLine : PropertyAttribute
{
    public readonly string Title;
    public Color Color;
    public bool ColorizedField;

    private readonly Dictionary<string, Color> Colors =
    new Dictionary<string, Color>
    {
        {"white" , Color.white},
        {"black" , Color.black},
        {"red" , Color.red},
        {"gray" , Color.gray},
        {"cyan" , Color.cyan},
        {"blue" , Color.blue},
        {"green" , Color.green},
        {"yellow" , Color.yellow},
        {"magenta" , Color.magenta},
    };

    /// <summary>
    ///  Draws a line with a title and color between the fields.
    /// </summary>
    public HorizontalLine()
    {
        this.Title = string.Empty;
        Color = Color.white;
    }

    /// <summary>
    ///  Draws a line with a title and color between the fields.
    /// </summary>
    /// <param name="title">Title</param>
    public HorizontalLine(string title)
    {
        this.Title = title;
        Color = Color.white;
    }

    /// <summary>
    ///  Draws a line with a title and color between the fields.
    /// </summary>
    /// <param name="title">Title</param>
    /// <param name="color">Line and field background color : 
    /// "white", "black", "red", "cyan", "blue", "green", "yellow", "magenta"</param>
    public HorizontalLine(string title, string color)
    {
        this.Title = title;
        string _lowerCaseColorString = color.ToLower();
        this.Color = Colors[_lowerCaseColorString];
    }

    /// <summary>
    ///  Draws a line with a title and color between the fields.
    /// </summary>
    /// <param name="title">Title</param>
    /// <param name="color">Line and field background color :
    /// "white", "black", "red", "cyan", "blue", "green", "yellow", "magenta"</param>
    /// <param name="colorizedField">is background colorized?</param>
    public HorizontalLine(string title, string color, bool colorizedField)
    {
        this.Title = title;
        string _lowerCaseColorString = color.ToLower();
        this.Color = Colors[_lowerCaseColorString];
        ColorizedField = colorizedField;
    }
}