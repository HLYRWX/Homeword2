abstract class Animal
{
    public abstract void voice();
}
class Pig implements Animal
{
    public void voice()
{
    System.out.println("henghengheng");
}
}
class Dog implements Animal
{
    public void voice()
{
    System.out.println("wangwangwang");
}
}
class Cat implements Animal
{
    public void voice()
{
    System.out.println("喵喵喵");
}
}
class Store
{
    public Animal getInstance(String name)
    {
        if ("Pig".equals(name))
        {
            return new Pig();
        }
        else if ("Dog".equals(name))
        {
            return new Dog();
        }
        else
        {
            return new Cat();
        }
    }
}