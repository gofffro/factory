using System;

namespace factory
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Creator creator;

      creator = new ConcreteCreatorA();
      IProduct productA = creator.FactoryMethod();
      productA.Operation();

      creator = new ConcreteCreatorB();
      IProduct productB = creator.FactoryMethod();
      productB.Operation();
    }
  }

  public interface IProduct
  {
    void Operation();
  }

  public class ConcreteProductA : IProduct
  {
    public void Operation()
    {
      Console.WriteLine("Операция продукта A");
    }
  }

  public class ConcreteProductB : IProduct
  {
    public void Operation()
    {
      Console.WriteLine("Операция продукта B");
    }
  }

  public abstract class Creator
  {
    public abstract IProduct FactoryMethod();
  }

  public class ConcreteCreatorA : Creator
  {
    public override IProduct FactoryMethod()
    {
      return new ConcreteProductA();
    }
  }

  public class ConcreteCreatorB : Creator
  {
    public override IProduct FactoryMethod()
    {
      return new ConcreteProductB();
    }
  }
}
