# Clock
Code about converting time, from numbers to strings


Converts time specified in numbers in a sentence. 
9k lines of code in total.

-uses 4 documents:
  - program.cs = main one where the program will ask input. It detects the number if its out of bounds and will ask them endlessly till its inside bounds. 
  If it is out of range of the INT identifier or contains strings it will end the program.
  - minuto.cs = interface where the minute strings are stored as public void.
  - ora.cs = interface where the minute strings are stored as public void. it also stores the initial sentence so that the sentence will make sense.
  - operation.cs = class which inherits the two interfaces, allowing to make a public void of nested if statements for each hour and minutes, allowing
  the document be as long as 8k lines
  
Additional notes:
- ran into a stack overflow exception which was fixed by get-setting automatically the values of AA and BB in the operation.cs file, and by putting the objects created
by the interfaces ora and minuto inside the public void dothemath.
