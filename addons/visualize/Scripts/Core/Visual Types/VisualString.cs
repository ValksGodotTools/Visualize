﻿using Godot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visualize.Core;

public static partial class VisualControlTypes
{
    private static VisualControlInfo String(object initialValue, Action<string> valueChanged)
    {
        LineEdit lineEdit = new() { Text = initialValue.ToString() };
        lineEdit.TextChanged += text => valueChanged(text);

        return new VisualControlInfo(new LineEditControl(lineEdit));
    }
}

public class LineEditControl : IVisualControl
{
    private readonly LineEdit _lineEdit;

    public LineEditControl(LineEdit lineEdit)
    {
        _lineEdit = lineEdit;
    }

    public void SetValue(object value)
    {
        if (value is string text)
        {
            _lineEdit.Text = text;
        }
    }

    public Control Control => _lineEdit;

    public void SetEditable(bool editable)
    {
        _lineEdit.Editable = editable;
    }
}
