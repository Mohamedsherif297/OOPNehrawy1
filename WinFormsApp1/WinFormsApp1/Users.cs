﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Managment__System
{
    public class User
    {
        public static string Old_members_FBath = "D:\\semester4\\Old_Members_database.csv";
        public static string Admins_FBath = "D:\\semester4\\AdminsDataBase.csv";

        // Encapsulated properties
        private string name="";
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public virtual void Sign(string name)
        {
            Name = name;
        }

        // Overloaded method
        public virtual void Sign(string name, string phone,string department)
        {
            Name = name;
            department = "";
        }

        public virtual bool Log(string id, string password)
        {
            return false;
        }
    }

    public class Admin : User
    {
        // Encapsulation with properties
        public string ID { get; private set; }
        private string password;

        public Admin(string id, string password)
        {
            ID = id;
            this.password = password;
        }

        // Override Log method to verify credentials(pass/id)
        public override bool Log(string id, string password)
        {
            return ID == id && this.password == password;
        }
    }

    public class NewMember : User
    {
        private string phoneNumber="";
        public string depart="";
        public int TrustScore { get; private set; }//auto implemented property

        public string PhoneNumber
        {
            get => phoneNumber;
            private set => phoneNumber = value;
        }
        public NewMember (string name , string phoneNumber,string department)
        {
            this.Name = name;
            this.PhoneNumber = phoneNumber;
            this.depart= department;
        }
        // Override Sign to register user
        public override void Sign(string name, string phone,string department)
        {
            base.Sign(name, phone,department);
            PhoneNumber = phone;
            this.depart = department;
            TrustScore = 0;
            if (!File.Exists(Old_members_FBath))
            {
                File.WriteAllText(Old_members_FBath,$"Name,Phone,TrustScore,Depart\n");
            }
               File.AppendAllText(Old_members_FBath, $"{name},{phone},{TrustScore},{department}\n");


        }

        public class oldMember : User
        {
            private string phoneNumber = "";
            public int TrustScore { get; private set; }

            public string PhoneNumber
            {
                get => phoneNumber;
                private set => phoneNumber = value;
            }

            // Override Sign to check existing user


        }


    }
}
