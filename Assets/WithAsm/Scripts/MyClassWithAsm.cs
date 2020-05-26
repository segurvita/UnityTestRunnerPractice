public class MyClassWithAsm
{
    private string name;

    public MyClassWithAsm()
    {
        name = string.Empty;
    }

    public MyClassWithAsm(string name)
    {
        this.name = name;
    }

    public void SetName(string name)
    {
        this.name = name;
    }

    public string GetName()
    {
        return name;
    }
}
