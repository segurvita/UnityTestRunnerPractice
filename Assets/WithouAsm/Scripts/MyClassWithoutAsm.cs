public class MyClassWithoutAsm
{
    private string name;

    public MyClassWithoutAsm()
    {
        name = string.Empty;
    }

    public MyClassWithoutAsm(string name)
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
