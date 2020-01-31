### Homework Chapter 6
### David Babers
### ISTA 220: Programming in C#
### Charles Carter
### January 29, 2020

1. What is an *exception*?

* **An response to an exceptional circumstance that arises while a program is running, such as an attempt to divide by zero. Exceptions provide a way to transfer control from one part of a program to another.**

2. What happens in a *try* block if the program executes without errors?

* **The statement continues to run one after another until completion**

3. How does the catch mechanism work for unhandled exceptions?

* **The control does not return the method that caused the exception**

4. What happens in a program if an exception block fails to handle an particular error?

* **It will continue to throw the exception until windows handles it**

5. What is the parent class for all exceptions? How does this work?

* **systemexceptions when an error occurs, either the system or the current application reports it by throwing an exception. **

6. How do you determine the type of an error?

* **error handling logic**

7. What is the purpose of integer checking?

* **To ensure there will not be an overflow exception**

8. What is the range of values than a signed Int32 type can contain? State the lowest value and the highest value.

* **32 bytes -217483647 +217483647**

9. What is the range of values than an unsigned Int32 type can contain? State the lowest value and the highest value. What is the difference between a signed integer and an unsigned integer? Can signed
integers and unsigned integers represent the same amount of numbers?

* **0 to 4294967295 a signed int can hold both - and +. unsigned can hold a larger - value**

10. What does the *finally* do?

* **fianlly block will exccute when the try/catch leaves the execution.**

11. (Thought question) When would you not use a finally block in a try/catch construction?

 * **When I do not want the try block to finish**
