using System;

abstract class Telephone
{
    protected string phonetype;

    public Telephone(string type)
    {
        phonetype = type;
    }

    public abstract void Ring();
}

class ElectronicPhone : Telephone
{
    public ElectronicPhone() : base("Digital")
    {
    }

    public void Run()
    {
        Ring();
    }

    public override void Ring()
    {
        Console.WriteLine($"Ringing the {phonetype} phone.");
    }
}

class DigitalPhone : Telephone
{
    public DigitalPhone() : base("Digital")
    {
    }

    public override void Ring()
    {
        Console.WriteLine($"Ringing the {phonetype} phone differently.");
    }
}

class TalkingPhone : Telephone
{
    public TalkingPhone() : base("Talking")
    {
    }

    public override void Ring()
    {
        Console.WriteLine($"Ringing the {phonetype} phone differently.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        ElectronicPhone electronicPhone = new ElectronicPhone();
        DigitalPhone digitalPhone = new DigitalPhone();
        TalkingPhone talkingPhone = new TalkingPhone();

        electronicPhone.Run();
        digitalPhone.Ring();
        talkingPhone.Ring();
    }
}
