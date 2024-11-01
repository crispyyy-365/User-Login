using IPerson;

Employee employee1 = new("Walter", "White");
Employee employee2 = new("Jesse", "Pinkman");
Employee employee3 = new("Skyler", "White");
Employee employee4 = new("Saul", "Goodman");

Department department1 = new("A");
Department department2 = new("B");

Department.AddEmployee(employee1);
Department.AddEmployee(employee2);
Department.AddEmployee(employee3);
Department.AddEmployee(employee4);

Department.AddDepartment(department1);
Department.AddDepartment(department2);

Employee.ShowEmployeeCount();
