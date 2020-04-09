### Homework 11
### David Babers
### ISTA 220:  C# Fundamentals
### Charles Carter
### February 20, 2020



1.	What is a parameter array?

* **When you need to declare a indefinite number of arguments.**

2.	How do you define a method that takes an arbitrary number of arguments?

* **A method that uses a parameter array effectively has a completely arbitrary list of parameters, and none of them has a default value. Furthermore, the method can determine exactly how many arguments the caller provided.**

3.	How do you call a method that takes an arbitrary number of arguments?

* **private static int Method2(params int [] paramlist)**

4.	Why can’t you use an array to pass an arbitrary number of arguments to a method?

* **Because you need to define you have to specify a fix size.**

5.	How many parameters can a method have?

* **An unlimited amount**

6.	Do parameter arguments have to have the same type?

* **No, because the arguments will be put in the object array.**

7.	What is the difference between a method that takes a parameter argument and one that takes optional arguments?

* **-One takes optional arguments and has a fix param paramlist
    -The other takes a parameter arguments can have an arbitrary list of parameters and none of them have a default value.**

8.	How do you define a method that takes different (and arbitrary) types of arguments?

8.* **By using an object array.**


9.	Write a method that accepts any number of arguments of a given type.

* **Completed in class**

10.	Write a method that accepts any number of arguments of any type.

* **Completed in class**
