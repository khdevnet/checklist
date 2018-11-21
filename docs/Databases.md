# Databases
**ACID is an acronym that refers to Atomicity, Consistency, Isolation and Durability**
* Atomicity  
The atomicity property identifies that the transaction is atomic. An atomic transaction is either fully completed, or is not begun at all. Any updates that a transaction might affect on a system are completed in their entirety. If for any reason an error occurs and the transaction is unable to complete all of its steps, the then system is returned to the state it was in before the transaction was started.

* Consistency  
A transaction enforces consistency in the system state by ensuring that at the end of any transaction the system is in a valid state. If the transaction completes successfully, then all changes to the system will have been properly made, and the system will be in a valid state. If any error occurs in a transaction, then any changes already made will be automatically rolled back

* Isolation
When a transaction runs in isolation, it appears to be the only action that the system is carrying out at one time. If there are two transactions that are both performing the same function and are running at the same time, transaction isolation will ensure that each transaction thinks it has exclusive use of the system. This is important in that as the transaction is being executed, the state of the system may not be consistent. 
[Resource](https://msdn.microsoft.com/en-us/library/aa480356.aspx)