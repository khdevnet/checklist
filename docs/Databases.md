# Databases
#### Database normalization
* First Normal Form – The information is stored in a relational table and each column contains atomic values, and there are not repeating groups of columns.
* Second Normal Form – The table is in first normal form and all the columns depend on the table’s primary key.
* Third Normal Form – the table is in second normal form and all of its columns are not transitively dependent on the primary key
* Boyce–Codd normal form

[Resource](https://www.essentialsql.com/get-ready-to-learn-sql-database-normalization-explained-in-simple-english/)

#### ACID is an acronym that refers to Atomicity, Consistency, Isolation and Durability
* Atomicity  
The atomicity property identifies that the transaction is atomic. An atomic transaction is either fully completed, or is not begun at all. Any updates that a transaction might affect on a system are completed in their entirety. If for any reason an error occurs and the transaction is unable to complete all of its steps, the then system is returned to the state it was in before the transaction was started.

* Consistency  
A transaction enforces consistency in the system state by ensuring that at the end of any transaction the system is in a valid state. If the transaction completes successfully, then all changes to the system will have been properly made, and the system will be in a valid state. If any error occurs in a transaction, then any changes already made will be automatically rolled back

* Isolation
When a transaction runs in isolation, it appears to be the only action that the system is carrying out at one time. If there are two transactions that are both performing the same function and are running at the same time, transaction isolation will ensure that each transaction thinks it has exclusive use of the system. This is important in that as the transaction is being executed, the state of the system may not be consistent. 
* Durability A transaction is durable in that once it has been successfully completed, all of the changes it made to the system are permanent. There are safeguards that will prevent the loss of information, even in the case of system failure. By logging the steps that the transaction performs, the state of the system can be recreated even if the hardware itself has failed. The concept of durability allows the developer to know that a completed transaction is a permanent part of the system, regardless of what happens to the system later on.   

[Resource](https://msdn.microsoft.com/en-us/library/aa480356.aspx)

#### SQL Query
* SELECT - сообщает серверу какие данные следует извлечь
* FROM - собирает все источники данных в единый набор
* WHERE - фильтрует наборы данных собранных FROM
* GROUP BY - групирует большие множества в подмножества и применяет агрегатные функции
* HAVING - фильтрует сгрупированыые подмножества
* ORDER BY - определяет порядок сортировки

#### Возможные источники данных
* Таблицы SQL Server
* Подзапросы выступающие в роли временных таблиц, также называемые подвыборками
* Общие табличные представления CTE (вместо создания Views используется ключевое слово WITH)
* VIEWS хранят select запросы
* Пользовательские функции
* распределенные источники данных (Excel, Oracle)
