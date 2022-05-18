CREATE FUNCTION fun_SumSalaryOfEmployee(@employee_id int)
returns real
as
Begin
return 
(SELECT SUM(e.salary_per_hour * DATEDIFF(HH, s.startTime, s.endTime)) 
FROM schedule as s INNER JOIN employee as e ON s.employee_id = e.id
WHERE s.check_in IS NOT null AND e.id = @employee_id)
END