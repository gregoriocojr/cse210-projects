using System;

public class Words
{
    private string _text;
    private bool _isHidden;

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        return ($"{_isHidden} {_text}");
    }
}