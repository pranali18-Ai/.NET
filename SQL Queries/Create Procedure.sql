
CREATE procedure KiaraGetAllEmployees
as 
Begin 
	  Select Id, Name, Gender, City, DateOfBirth
	  from KiaraBussiness
End
