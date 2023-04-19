﻿namespace FourPillarsApp;

public class Hunter : Person, ISpeakable
{
    private string _camera = "";

    public Hunter(string fName, string lName, string camera = "") : base(fName, lName)
    {
        _camera = camera;
    }

    public string Shoot()
    {
        return $"{GetFullName()} takes a photo with their {_camera}";
    }

    public override string ToString()
    {
        return $"{base.ToString()}, _camera: {_camera}";
    }

    public override string GetFullName()
    {
        return $"Hunter {base.GetFullName()}";
    }

    public string Speak()
    {
        throw new NotImplementedException();
    }
}
