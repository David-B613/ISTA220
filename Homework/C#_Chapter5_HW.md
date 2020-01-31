### Homework Chapter 5
### David Babers
### ISTA 220: Programming in C#
### Charles Carter
### January 28, 2020

1. What is a *compound assignment operator?* How does it work?

* **The compound assignment operators consist of a binary operator and the simple assignment operator. They perform the operation of the binary operator on both operands and store the result of that operation into the left operand, which must be a modifiable value**

2. List all the compound assignment operators.

* **+= , -= , *= , /= , %= , &= , |= , ^= ,  <<= , >>= , =>**

3. List two ways to increment a numeric variable by 5. List two ways to decrement a numeric variable by 50.

* **number = ++ 4 , count += 4**

4. How long does a while loop run?

* **The variable "a" in the while loop controls the number of iterations that the loop performs**

5. What is an *iteratiion variable?* (Not in book)

* **It is loop variable**

6. What happens if you don't change the loop variable in the body of the while loop block?

* **The loop will in when the program no longer has any text to read then returns a null value.**

7. How many parts does a for loop statement have? Can you omit any of them? Can you omit all of them? What happens if you omit all of them?

* **There are four parts to a loop statement ** You can omit any of the three expression in the loop statement. It will create a infinite loop.

8. How do you guarantee that a loop runs at least once?

* **While loop**

9. What does the break statement do?

* **It is used to break or terminate the execution of loops**

10. What does the continue statement do?

* **Continue statement is used to pass a control to the next iteration of loops such as for, while, do-while or for each from the specified position by skipping the remaining code.**

11. (Thought question) Can you think of any reason why you would want to have an infinite loop? An "infinite loop" is a loop without an update variable that in effect runs forever. As you will see, these
kinds of loops are written intentionally to perform various kinds of tasks.

 * **when we write the console application, we may have some menu structure and it will keep on display to allow the users choose any one option.**
