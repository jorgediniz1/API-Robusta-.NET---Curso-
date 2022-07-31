namespace Manager.Domain.Entities
{
    public class User : Base
    {
  
        public string Name { get; private set; }
        public strinf Email { get; private set; }
        public string Password { get; private set; }


        protected User(){} //Construtor para o EF. 

        public User(string name, strinf email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
            _errors = new List<string>();
        }

        public void ChangeName(string name)
        {
            Name = name; 
            Validate();          
        }

        public void ChangePassword(string password)
        {
            Password = password;
            Validate();
        }
        
        public void ChangeEmail(string email)
        {
            Email = email; 
            Validate();
        }

        public override bool Validate()
        {
            
        }

    }
}