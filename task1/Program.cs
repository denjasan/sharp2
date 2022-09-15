using System;


ClassRoom clr = new(new BadPupil(), new ExcelentPupil());
clr.Print();


internal class ClassRoom
{
    private static Pupil[] _pupils = new Pupil[4];

    public ClassRoom(Pupil person1, Pupil person2, Pupil? person3 = null, Pupil? person4 = null)
    {
        _pupils[0] = person1;
        _pupils[1] = person2;
        _pupils[2] = person3 ?? new GoodPupil();
        _pupils[3] = person4 ?? new GoodPupil();
    }

    public void Print()
    {
        for (var i = 0; i < 4; i++)
        {
            Console.WriteLine($"Ученик номер {i + 1}:");
            _pupils[i].Print();
            Console.WriteLine();
        }
    }
}

public class Pupil
{
    public void Print()
    {
        Study();
        Read();
        Write();
        Relax();
    }

    public virtual void Study()
    {
        Console.WriteLine("Учится");
    }

    public virtual void Read()
    {
        Console.WriteLine("Читает");
    }

    public virtual void Write()
    {
        Console.WriteLine("Пишет");
    }

    public virtual void Relax()
    {
        Console.WriteLine("Отдыхает");
    }
}

public class ExcelentPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("Отлично учится");
    }

    public override void Read()
    {
        Console.WriteLine("Много Читает");
    }

    public override void Write()
    {
        Console.WriteLine("Много пишет");
    }

    public override void Relax()
    {
        Console.WriteLine("Мало отдыхает");
    }
}

public class GoodPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("Нормально учится");
    }

    public override void Read()
    {
        Console.WriteLine("Часто Читает");
    }

    public override void Write()
    {
        Console.WriteLine("Иногда пишет");
    }

    public override void Relax()
    {
        Console.WriteLine("Бывает, что отдыхает");
    }
}

public class BadPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("Плохо учится");
    }

    public override void Read()
    {
        Console.WriteLine("Мало Читает");
    }

    public override void Write()
    {
        Console.WriteLine("Мало пишет");
    }

    public override void Relax()
    {
        Console.WriteLine("Постоянно отдыхает");
    }
}
