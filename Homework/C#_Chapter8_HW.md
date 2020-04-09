### Homework Chapter 8
### David Babers
### ISTA 220: Programming in C#
### Charles Carter
### February 6, 2020

1. What is the difference between *deep copy* and *shallow copy*?

* **It is a process of creating a new object and then copying the fields of the current object to the newly created object to make a complete copy of the internal reference types. If the specified field is a value type, then a bit-by-bit copy of the field will be performed. / Shallow copy is a bit-wise copy of an object. A new object is created that has an exact copy of the values in the original object. If any of the fields of the object are references to other objects, just the reference addresses are copied i.e., only the memory address is copied.**

2. What is the value of a reference after you declare and initialize it?

* **Once initialize a reference can not be changed **

3. How do you declare a value type?

* **You can declare a value type by using the reserved keyword, for example, Decimal . You can also use the New keyword to initialize a value type. This is especially useful if the type has a constructor that takes parameters.**

4. How do you declare a reference type?

* **When a variable is declared as a reference, it becomes an alternative name for an existing variable. A variable can be declared as reference by putting '&' in the declaration.**

5. Does C# allow you to assign NULL to a value type?

* **Yes**

6. Can you assign a nullable value type to a non-nullable variable of the same type? Why or why not?

* **A nullable type allows you to assign a null value to a variable. Nullable types can only work with Value Type not with reference types.**

7. What is the difference between the stack and the heap?

* **The primary difference is the stack memory is used to store local variables and function to call on the heap memory where the object is stored.  **

8. What does it mean when we say that all classes are *specialized types*?

* **A subclass inherits state and behavior from all of the its ancestors.**

9. What does *ref* do?

* **The ref keyword in C# is used for passing or returning references of values to or from Methods. Basically, it means that any change made to a value that is passed by reference will reflect this change since you are modifying the value at the address and not just the value.**

10. What does *out* do?

* **The out is a keyword in C# which is used for the passing the arguments to methods as a reference type. It is generally used when a method returns multiple values. Important Points: ... It is also similar to the in keyword but the in keyword does not allow the method that called to change the argument value but ref allows.**

11. Describe *boxing* and *unboxing* in your own words.

 * **Boxing is the process when you turn a value type into a object type. Unboxing extracts the value type from the object **

 12. What does *cast* do?

* ** is a method by which a value is converted from one data type to another. Cast is an explicit conversion by which the compiler is informed about the conversion and the resulting possibility of data loss**       
