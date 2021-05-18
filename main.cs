using System;

public interface PersonalComputer
{
    uint calCost();
    void description();
}
public class Laptop : PersonalComputer
{
    public uint calCost()
    {
        return 12000;
    }
    public void description()
    {
        Console.Write("You are buy a Laptop!");
    }
}
public class Desktop : PersonalComputer
{
    public uint calCost()
    {
        return 35000;
    }
    public void description()
    {
        Console.Write("You are buy a Desktop!");
    }
}
public class CdDrive : PersonalComputer
{
    private PersonalComputer pc;
    public CdDrive(PersonalComputer pc)
    {
        this.pc = pc;
    }
    public uint calCost()
    {
        return (uint)(100 + pc.calCost());
    }
    public void description()
    {
        pc.description();
        Console.Write("\n");
        Console.Write("WITH CD-ROM");
    }
}
public class Monitor : PersonalComputer
{
    private PersonalComputer pc;
    public Monitor(PersonalComputer pc)
    {
        this.pc = pc;
    }
    public uint calCost()
    {
        return (uint)(9500 + pc.calCost());
    }
    public void description()
    {
        pc.description();
        Console.Write("\n");
        Console.Write("WITH LED Monitor");
    }
}
public static class DecoratorPattern
{
    internal static void Main()
    {
        PersonalComputer pc = new Desktop();
        pc = new CdDrive(pc);
        pc = new Monitor(pc);
        pc.description();
        Console.Write("\n");
        Console.Write("COST: ");
        Console.Write(pc.calCost());
        Console.Write("\n");
    }
}
