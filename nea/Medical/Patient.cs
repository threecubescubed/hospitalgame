using System;
using System.Collections.Generic;
using System.Text;

namespace hospitalgame
{
    class Patient
    {
        private string firstName;
        private string lastName;
        private int age;
        private BodyManager bodyManager;

        public Patient(string _firstName, string _lastName, int _age)
        {
            firstName = _firstName;
            lastName = _lastName;
            age = _age;

            bodyManager = new BodyManager();
        }

        public BodyManager getBodyManager() { return bodyManager; }




    }
}
