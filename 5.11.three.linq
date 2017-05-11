<Query Kind="Statements">
  <Connection>
    <ID>abe07939-9af9-4a46-9fd3-104e461f6add</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>WorkSchedule</Database>
  </Connection>
</Query>

var results = from s in Skills
			  where s.RequiresTicket==true
			  select new{
			  	Description = s.Description,
				Employees = from e in s.EmployeeSkills
				orderby e.YearsOfExperience descending
				select new{
					Name=e.Employee.FirstName+" "+e.Employee.LastName,
					Level = e.Level,
					YearsOfExperience = e.YearsOfExperience
				}
			  };
results.Dump();