CREATE TABLE Employees (
    EmployeeID INT,
    EmployeeName VARCHAR(50),
    Department VARCHAR(50),
    Salary INT
);

INSERT INTO Employees VALUES
(1, 'John', 'IT', 60000),
(2, 'Alice', 'IT', 75000),
(3, 'Bob', 'HR', 50000),
(4, 'David', 'HR', 65000),
(5, 'Emma', 'IT', 75000);

SELECT
    EmployeeName,
    Department,
    Salary,
    RANK() OVER (ORDER BY Salary DESC) AS SalaryRank,
    DENSE_RANK() OVER (ORDER BY Salary DESC) AS DenseRank,
    ROW_NUMBER() OVER (ORDER BY Salary DESC) AS RowNum
FROM Employees;
