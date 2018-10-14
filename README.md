Inheritance is one of the core concepts of object-oriented programming languages. 
It is a mechanism where you can to derive a class from another class for a hierarchy of classes that share a set of attributes and methods.

You can use it to declare different kinds of exceptions, add custom logic to existing frameworks, and even map your domain model to a database.

each class can only be derived from one other class. That class is called a superclass, or parent class. The derived class is called subclass, or child class.

You use the keyword extends to identify the class that your subclass extends. If you don’t declare a superclass, your class implicitly extends the class Object. Object is the root of all inheritance hierarchies; it’s the only class in Java that doesn’t extend another class.

                      Class(Base Class)
             __________|____________
            |                       |
     Derived Class                 Derived class
     |                                  |
     Instantiation of a class          Instantiation of a class

Access modifiers define what classes can access an attribute or method.
Inheritance not only adds all public and protected methods of the superclass to your subclass, but it also allows you to replace their implementation. 
The method of the subclass then overrides the one of the superclass. That mechanism is called polymorphism.
