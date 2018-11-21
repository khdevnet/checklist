# CodeQuality
**SoC (Separation of Concerns)**  
Is the process of breaking a computer program into distinct features that overlap in functionality as little as possible.
A concern is any piece of interest or focus in a program. Typically, concerns are synonymous with features or behaviors.
[wikipedia](http://en.wikipedia.org/wiki/Separation_of_concerns)

**The Law of Demeter (the Principle of Least Knowledge)**  
Each unit should have only limited knowledge about other units: only units “closely” related to the current unit. Each unit should only talk to its friends; don’t talk to strangers.   
Example:    
Violating LOD 'person.getName().getBytes()'
 ```
  public final class NetworkConnection {
   public void send(Person person) {
      sendBytes(person.getName().getBytes());
      sendBytes(person.getPhoto().getBytes();
      ...
   }
}
  ```
  
**DRY principle (Do not repeat yourself)**    
Example:    
Violating
```
let isPositionCorrect = false
if isPositionCorrect {
    updateUI("Position Correct", isPositionCorrect)
} else {
    updateUI("Position InCorrect", isPositionCorrect)
}
```
Fixed
```
let message = isPositionCorrect ? "Position Correct" : "Position InCorrect"
updateUI(message, isPositionCorrect)
```