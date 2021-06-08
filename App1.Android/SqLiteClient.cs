using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using App1.Dependencies;
using App1.Droid;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Xamarin.Forms;

[assembly: Dependency(typeof(SqLiteClient))]
namespace App1.Droid
{
    public class SqLiteClient : IDataBase
    {
        public SQLiteConnection GetConnection()
        {
            String bbddfile = "HOSPITAL.db3";
            String rutadocumentos = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            String path = Path.Combine(rutadocumentos, bbddfile);
            SQLite.SQLiteConnection cn = new SQLite.SQLiteConnection(path);
            return cn;
        }
    }
}