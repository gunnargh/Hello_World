namespace _12_Employee
{
    internal class Employee
    {
        public string Name { get; internal set; }
        public string Type { get; internal set; }
        public int Id { get; internal set; }
        
        public Employee()
        {
        }

        public Employee(string Name, string Type, int Id)
        {
            this.Name = Name;
            this.Type = Type;
            this.Id = Id;
        }

        
    }
}