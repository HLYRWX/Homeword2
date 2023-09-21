// See https://aka.ms/new-console-template for more information
using System.Security.Claims;
using System;

Console.WriteLine("Hello, World!");
#include<iostream>
using namespace std;
class rectangle
{
    private:
	int wide, length;
    public:
	void set() { cin >> wide; }
    void get() { cin >> length; }
    int area()
    {
        int s;
        s = wide * length;
        return s;
    }
    int perimeter()
    {
        int c;
        c = wide + length;
        return c;
    }
};
int main()
{
    rectangle rec;
    rec.set();
    rec.get();
    cout << "面积：" << rec.area() << "  " << "周长：" << rec.perimeter() << endl;
    return 0;
}

public class Person
{
    private int age;
    private String name;


    public Person()
    {
    }

    public Person(int age, String name)
    {
        this.age = age;
        this.name = name;
    }

    public int getAge()
    {
        return age;
    }

    public void setAge(int age)
    {
        this.age = age;
    }

    public String getName()
    {
        return name;
    }

    public void setName(String name)
    {
        this.name = name;
    }

    @Override
    public String toString()
    {
        return "Person{" +
                "age=" + age +
                ", name='" + name + '\'' +
                '}';
    }
}

public class Test
{

    public static void main(String[] args) throws Exception, SecurityException {
        Class clas = Person.class;
    Constructor constructor = clas.getConstructor(int.class, String.class);
        Person person = (Person)constructor.newInstance(38, "马蓉");
    System.out.println(person);
    Method setName = clas.getMethod("setName", String.class);
        setName.invoke(person, "王宝强");
        Field age = clas.getDeclaredField("age");
    age.setAccessible(true);
        age.set(person, 35);
        System.out.println(person);

}
}




