<Query Kind="Statements">
  <Connection>
    <ID>abe07939-9af9-4a46-9fd3-104e461f6add</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>WorkSchedule</Database>
  </Connection>
</Query>

var results =from s in Skills 
			 orderby s.Description 
			 select new{
				Accountant = s.Description
			  }; 		  
results.Dump();