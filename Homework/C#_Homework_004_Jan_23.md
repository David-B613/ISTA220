### Homework 004
### David Babers
### ISTA 220:  Programming fundamentals in C#
### Charles Carter
### January 23, 2020

1. What are all the possible values of a *Boolean expression?*

* **True and False "2"**

1. List eight *Boolean operators.*

1. **==**
1. **!=**
1. **>**
1. **>=**
1. **<**
1. **<-**
1. **&&**
1. **||**


3. What is the general *short circuiting?* * This question has a short and simple answer and you do not need to have a detailed response.

* **The evaluation of both operands when ascertaining the result of a conditional logical expression**

4. What are the difference in how *short circuiting* works for && and ||?

* **If the left operand of the && operator evaluates to false, the result of the entire expression must be false, regardless of the value of the right operand. Similarly, if the value of the left operand of the || operator evaluates to true, the result of the entire expression must be true, irrespective of the value of the right operand.**

5. Look at the list of operators. What operator has the highest precedence? Which has the lowest?

* **Primary = Highest and Assignment = Lowest**

6. In an *if* or *else* construction using multiple lines of code, what effect does the use of curly braces have?

* **If you omit the braces, the C# compiler associates only the first statement  (seconds = 0;) with the if statement. The subsequent statement (minutes++;) will not be recognized by the compiler as part of the if statement when the program is compiled.**

7. In a *switch* statement what happens if you omit *break*?

* **If you don't include break in any of case then all the case below will be executed and until it sees break. And if you don't include break in default then it will cause no effect as there are not any case below this 'Default' case.**

8. (Not in book) What is a *recursive* method? Using a language you know (such as English), write a recursive method that adds up the integers in a list of integers. The input to the method is a list of integers and the output is a scalar value representing a sum.

* **A recursive function is a function that calls itself. An example of this would be build a 3 story house, if I want to build a 3 story house I must build a 2 story house first then add one story.**

9. (Not in book) Read a short summary of De Morgan's laws.

(a) Explain how this statement, "It's not snowing or raining," is the same as this statement, "It's not snowing and it's not raining."

(b) Explain how this statement, "I'm not running and walking," is the same as this statement, "I'm not running or I'm not walking."

* **The both are true Boolean expressions. They are using the if "||" and "&&" operators. In the first statement if it is not snowing or raining it is true. The second statement says if it not raining or snowing. It would stand the same for part B on this question.
