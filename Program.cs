using System;


public delegate void MyDelegate(string text);
class ClassWithEvent
{
    public event MyDelegate MyEvent;

    public void GenerateEvent(string eventName)
    {
        MyEvent.Invoke(eventName);
    }
}

class SecondClass
{
    public void HandleEvent(string eventName)
    {
        Console.WriteLine($"Событие сгенерировано объектом: {eventName}");
    }
}
class HelloWorld
{
    static void Main()
    {
        ClassWithEvent obj1 = new ClassWithEvent();
        ClassWithEvent obj2 = new ClassWithEvent();
        SecondClass obj3 = new SecondClass();

        obj1.MyEvent += obj3.HandleEvent;
        obj2.MyEvent += obj3.HandleEvent;

        obj1.GenerateEvent("Первый объект");
        obj2.GenerateEvent("Второй объект");

    }
}
