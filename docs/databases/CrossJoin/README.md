# CROSS JOIN
### TASK
Calculate average mark groped by student and subject.

### Configure Database
* Create Database University
* Run Script University_Database.sql

### Solution
```SQL
SELECT Students.NAME, Subjects.Name, ISNULL(CONVERT(nvarchar(10), AVG(Students_Subjects.Mark)),'N/A')
FROM Students
CROSS JOIN Subjects 
LEFT JOIN Students_Subjects on Students.Id = Students_Subjects.SudentId
GROUP BY Students.NAME, Subjects.Name
```

