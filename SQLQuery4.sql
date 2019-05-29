--declare @StudentName nvarchar(20)
--set @StudentName = 'Antonio'
--select * from Student where FirstName = @StudentName

--declare @StudentTable table(ID int,FirstName nvarchar(50),DateOfBirth date)
--insert into @StudentTable select ID,FirstName,DateOfBirth from Student
--where Gender = 'F'
--select * from @StudentTable

--create table #TempTable (LastNames nvarchar(50), EnrolledDates date)
--insert into #TempTable 
--select LastName, EnrolledDate from Student
--where FirstName like 'A%' and Gender = 'M' 
--select * from #TempTable where len(LastNames) = 7

--select * from Teacher where 
--len(FirstName) < 5 and SUBSTRING(FirstName,1,3) = SUBSTRING(LastName,1,3)

--create function dbo.fn_FormatStudentName (@StudentId int)
--returns nvarchar(50)
--as 
--begin
--declare @Result nvarchar(50)
--select @Result = SUBSTRING(s.StudentCardNumber,4,8)+ ' - '+substring(s.FirstName,1,1)+'.'+(s.LastName)
--from Student s
--where ID = @StudentId
--return @Result
--end
--select dbo.fn_FormatStudentName(10)

--drop function if exists fn_FormatStudentName
--select * from Student

--create function dbo.fn_MultiStatementTable(@TeacherId smallint, @CourseID smallint)
--returns @Result Table(StudentFirstName nvarchar(50), StudentLastName nvarchar(50),Grade int, CreatedDate datetime)
--as
--begin
--insert into @Result
--select s.FirstName as StudentFirstName, s.LastName as StudentLastName,g.Grade as Grade, g.CreatedDate as CreatedDate
--from Grade g
--inner join Student s on s.ID = g.StudentID
--inner join Teacher t on t.ID = g.TeacherID
--inner join Course c on c.ID = g.CourseID
--where c.ID = @CourseID and t.ID = @TeacherId
--order by Grade
--return 
--end

--select * from dbo.fn_MultiStatementTable(4,4)
--select * from Grade where CourseID = 4
--select * from student where ID = 111




