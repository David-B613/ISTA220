### Homework 003
### David Babers
### ISTA 220:  Programming fundamemethntals in C#
### Charles Carter
### January 22, 2020

1. What is a *method*

* **A method is a named block of code that expects outside values and returns values to the outside.**

2. What is the difference between a function and a procedure/subprocedure/subroutine?

* **A Function must return a value but in Stored Procedures it is optional: a procedure can return 0 or n values.**

3. What does a return statement do?

* **If you want a method to return information (that is, its return type is not void), you must include a return statement at the end of the processing in the method body.**

4. What is an expression bodied method?

* **An expression-bodied method consists of a single expression that returns a value whose type matches the method's return type, or, for methods that return void , that performs some operation**

5. What is the scope of a variable?

* **Scope refers to the visibility of variables. In other words, which parts of your program can see or use it**

6. What is an overloaded method.

* **If two identifiers have the same name and are declared in the same scope, they are said to be overloaded. Often an overloaded identifier is a bug that is trapped as a compile-time error.**

7. How do you call a method that requirements arguments?

* **The arguments must be compatible with the parameter type but the argument name (if any) used in the calling code doesn't have to be the same as the parameter named defined in the method.**

8. How do you write a method, that is specify the method definition, that requires a parameter list?

* **Specify the method name, parameter list, and return type, followed by the body of the method between braces.**

9. How do you specify a parameter as optional when defining a method?

* **The difference with methods that take optional parameters is that you can omit the corresponding arguments and the method will use the default value when it runs.**

10. How do you pass a argument to a method as a named parameter?

* **To pass an argument as a named parameter, you specify the name of the parameter, followed by a colon and the value to use**

11. How do you return values from a method? Can you return multiple values how?

* **Write a return statement that returns a tuple**

12. How does the complier resolve an ambiguity between named arguments and optional parameters?

* **The compiler can distinguish between the methods because they have different parameter lists**
