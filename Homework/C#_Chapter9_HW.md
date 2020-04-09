### Homework 09
### David Babers
### ISTA 220:  Programming C# fundamentals
### Charles Carter
### February 12, 2020

1.	What is an enum?

* **An enum is a value data type.**

2.	Declare an enum for military ranks, either officer or enlisted. Name it Ranks. What are the symbols, like Private, Corporal, Sergeant or Lieutenant, Captain, Major?

* **emnum Military_Ranks {Private, Corporal, Sergeant, Lieutenant, Captain, Major};**

3.	Using the Ranks enum, assign a rank to yourself and a friend.

* **Corporal = Babers
    Major = Miller**

4.	Determine the numeric index of particular ranks, using the Ranks enum.

* **0 = Private, 1 = Corporal, and 2 = Sergeant**

5.	How do you select the type of an enum?

* **Military_Ranks.Corporal**

6.	What is a struct?

* **A structure is a value type data type. It helps you to make a single variable hold related data of various data types.**

7.	List some differences between classes and structs.

* **Basically, a class combines the fields and methods(member function which defines actions) into a single unit. A structure is a collection of variables of different data types under a single unit. It is almost similar to a class because both are user-defined data types and both hold a bunch of different data types.**

8.	Are structs stored on the stack or on the heap? What about enums?

* **Structs are stored on the stack and enums are stored on the heap.**

9.	Review the documentation for the C# System.Int32 struct. List the fields. List the methods.

* **I have no clue.**

10.	Declare a struct named DOD with four branches.

* **Struct DOD
{
  string Army
  string Navy
  string Marine Corps
  string Air force
  }**

11.	Why can’t you create a default constructor for a struct?

* **Can not contain explicit parameterless constructor**

12.	What is CIL? What does the CLR do to the CIL?

* **CIL (Common Intermediate Language) is a bytecode and the language of the . NET platform into which are compiled source code written in high level languages. Role of CLR in the execution of a C# program
Language specific compiler compiles the source code into the MSIL(Microsoft Intermediate Language) which is also know as the CIL(Common Intermediate Language) or IL(Intermediate Language) along with its metadata.**
