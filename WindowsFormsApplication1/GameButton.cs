using System;
using System.IO;

public class GameButton
{
    private string name;
    private string path;
    public GameButton(string name)
    {
        this.name = name;
        this.path = Directory.GetCurrentDirectory();
        path += "\\app\\" + name + "\\" + name + ".exe";
    }
    public string getName()
    {
        return this.name;
    }
    public string getPath()
    {
        return this.path;
    }
    
}
