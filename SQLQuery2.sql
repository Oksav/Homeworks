--select * 
--from Student
--where FirstName = 'Antonio'

--select * 
--from Student 
--where DateOfBirth > '1999-01-01'

--select *
--from Student
--where Gender = 'M'

--select *
--from Student
--Where LastName LIKE 'T%'

--select * 
--from Student
--where EnrolledDate LIKE '1998-01%'

--select * 
--where LastName LIKE 'T%' and EnrolledDate LIKE '1998-01%'

--select * 
--from Student
--where FirstName = 'Antonio'
--ORDER BY LastName

--select *
--from Student
--order by FirstName

--select * 
--from Student
--order by EnrolledDate desc

--select FirstName
--from Teacher
--union all
--select FirstName
--from Student
--order by FirstName

--select FirstName 
--from Teacher
--union 
--select FirstName
--from Student
--order by FirstName

--select FirstName
--from Teacher
--intersect
--select FirstName
--from Student
--order by FirstName

--alter table GradeDetails
--add constraint DF_AchievementMaxPoints
--default 99 for AchievementMaxPoints 
-----------------------------------------------------------------------
--alter table GradeDetails with check
--add constraint CHK_AchievementPoints
--check (AchievementPoints <= AchievementMaxPoints)

--insert into GradeDetails(GradeID,AchievementTypeID,AchievementPoints,AchievementMaxPoints,AchievementDate)
--values(2111,9,99,100,'2010-10-10')
--insert into GradeDetails(GradeID,AchievementTypeID,AchievementPoints,AchievementMaxPoints,AchievementDate)
--values(1111,9,110,100,'2010-10-10')

--select * from GradeDetails	
--where GradeID = 2111
 -----------------------------------------------------------------------
--alter table AchievementType with check
--add constraint UC_Name unique (Name)

--insert into AchievementType(Name,Description,ParticipationRate)
--values ('Ispit','fuck',22)
------------------------------------------------------------------------

--alter table Grade with check
--add constraint [FK_Grade_Teacher]
--foreign key ([TeacherID])
--references Teacher ([ID])

--select c.Name as CourseName, a.Name as AchievementTypeName
--from Course c
--cross join AchievementType a 

--select t.ID
--from Grade g
--inner join Teacher t on t.ID = g.TeacherID 


--select distinct t.FirstName
--from Teacher t
--left join Grade g on t.ID = g.TeacherID
--where g.Grade is not null


select s.*
from Student s
right join Grade g on s.ID = g.StudentID
where g.Grade < 7
-- all have exam grades, no nulls so i did less than 7


--List all Students without exam Grade (using Right Join)


