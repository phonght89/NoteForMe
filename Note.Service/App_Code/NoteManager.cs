using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Note.Data;

/// <summary>
/// Summary description for NoteManager
/// </summary>
public static class NoteManager
{
    private static NoteContext _currentContext = new NoteContext(GetConnectionString());

    public static NoteContext CurrentContext
    {
        get { return _currentContext; }
    }

    public static string GetConnectionString()
    {
        var connecttionString = global:: System.Configuration.ConfigurationManager.ConnectionStrings["NoteContext"].ConnectionString;
        return connecttionString;
    }
}