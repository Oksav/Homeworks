use SEDCHome

--declare @FirstName nvarchar(50)
--set @FirstName = 'Antonio'
--select * from Student where FirstName = @FirstName

--declare @StudentList Table
--(StudentID int,FirstName nvarchar(50),DateOfBirth date)
--insert into @StudentList 
--select ID, FirstName, DateOfBirth from Student
--where Gender = 'F'
--select * from @StudentList
--select * from @StudentList where DateOfBirth < '1992-02-22'



--create table #StudentList1
--(LastName nvarchar(50), EnrolledDate date)
--insert into #StudentList1 
--select LastName, EnrolledDate from Student
--where Gender = 'M' and FirstName like 'A%'
--select * from #StudentList1 a where LEN(a.LastName) > 5

--select COUNT(Grade) as Total
--from Grade

--select COUNT(Grade) as Total
--from Grade
--group by TeacherID

--select COUNT(Grade) as Total
--from Grade
--where StudentID < 100
--group by TeacherID


--select MAX(Grade) as Total, AVG(Grade) as Average
--from Grade
--group by StudentID

--select TeacherID, COUNT(Grade) as Total
--from Grade
--group by TeacherID	
--having COUNT(Grade) > 200

--select TeacherID, COUNT(Grade) as Total
--from Grade
--where StudentID < 100
--group by TeacherID
--having COUNT(Grade) > 50

--select StudentID, COUNT(Grade) as Total, MAX(Grade) as Maximum, AVG(Grade) as Average
--from Grade
--group by StudentID
--having MAX(Grade) = AVG(Grade)

--select StudentID, s.FirstName as FirstName, s.LastName as LastName,COUNT(Grade) as Total, MAX(Grade) as Maximum, AVG(Grade) as Average
--from Grade g
--inner join Student s on s.ID = g.StudentID
--group by StudentID, s.FirstName, s.LastName
--having MAX(Grade) = AVG(Grade)

--create view vv_StudentGrades
--as
--select StudentID,SUM(Grade) as Total
--from Grade g
--group by StudentID

--alter view vv_StudentGrades
--as 
--select s.FirstName as FirstName, s.LastName as LastName, SUM(Grade) as Total
--from Grade g
--inner join Student s on g.StudentID = s.ID
--group by s.FirstName, s.LastName


--select * from vv_StudentGrades
--order by Total desc



--Create new view (vv_StudentGradeDetails) that will List all Students (FirstName and LastName) and Count the courses he passed through the exam(Ispit
-- poslednovo go nema