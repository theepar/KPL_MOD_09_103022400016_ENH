using System;
using System.Collections.Generic;
using System.Text;

public class Confirmation
{
    public string en { get; set; }
    public string id { get; set; }

    public Confirmation() { }

    public Confirmation(string en, string id)
    {
        this.en = en;
        this.id = id;
    }
}