using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Markijan_NP_Gym.Models;
using Markijan_NP_Gym.Repositories.Concreate;
using Markijan_NP_Gym.Repositories.Abstract;
using Markijan_NP_Gym.Repositories.Concreate.Factories;
using Markijan_NP_Gym.Services.Concreate;
using Markijan_NP_Gym.Services.Abstract;
using Markijan_NP_T1.Logging;

namespace Markijan_NP_Gym
{
    public class Menu
    {
        private IMemberRep memberRep;
        private IMembershipRep membershipRep;
        private IMemberService memberService;

        public Menu()
        {
            var factory = FactoryProvider.GetReposFactory();
            memberRep = factory.GetMemberRep();
            membershipRep = factory.GetMembershipRep();
            memberService = new MemberService();
        }
        public void ShowMenu()
        {
            Console.WriteLine("You opened a gym manager\n");
            while (true)
            {
                try
                {
                    Console.WriteLine("Please select option:\n" +
                "1. Add new member.\n" +
                "2. Add new membership.\n" +
                "3. Show members' list.\n" +
                "4. Show memberships' list.\n" +
                "5. Show the oldest member.\n" +
                "0. Exit.");
                    string option = Console.ReadLine();
                    if (option == "1")
                    {
                        AddNewMember();
                        continue;
                    }
                    else if (option == "2")
                    {
                        AddNewMembership();
                        continue;
                    }
                    else if (option == "3")
                    {
                        MemberList();
                        continue;
                    }
                    else if (option == "4")
                    {
                        MembershipList();
                        continue;
                    }
                    else if (option == "5")
                    {
                        GetOldestMember();
                        continue;
                    }
                    else if (option == "0")
                    {
                        Console.WriteLine("The end of work.\n");
                        break;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch (Exception ex)
                {
                    Logger.Instance.LogError(ex.Message);
                    Console.WriteLine("Wrong option");
                }
            }
        }
        public void AddNewMember()
        {
            try
            {
                int id = memberRep.GetCount() + 1;
                string firstName;
                string lastName;
                int age;
                Console.WriteLine("\nAdd information about new member: \n");
                Console.Write("Members's first name: ");
                firstName = Console.ReadLine();
                Console.Write("Members's last name: ");
                lastName = Console.ReadLine();
                Console.Write("Age: ");
                age = Convert.ToInt32(Console.ReadLine());
                var member = new Member();
                member.Id = id;
                member.FirstName = firstName;
                member.LastName = lastName;
                member.Age = age;
                memberRep.Add(member);
                Console.WriteLine("Member was added");
            }
            catch (Exception ex)
            {
                Logger.Instance.LogError(ex.Message);
                Console.WriteLine("Membership was not added:(");
            }
        }
        public void AddNewMembership()
        {
            try
            {
                int id = membershipRep.GetCount() + 1;
                string name;
                float price;
                Console.WriteLine("\nAdd information about new membership: \n");
                Console.Write("Membership's  name: ");
                name = Console.ReadLine();
                Console.Write("Membership's price: ");
                price = Convert.ToSingle(Console.ReadLine());
                var membership = new Membership();
                membership.Name = name;
                membership.Price = price;
                membershipRep.Add(membership);
                Console.WriteLine("Membership was added");
            }
            catch (Exception ex)
            {
                Logger.Instance.LogError(ex.Message);
                Console.WriteLine("Membership was not added:(");
            }           
        }
        public void MemberList()
        {
            var members = memberRep.GetAll();
            members.Select(member => member.Print()).ToList().ForEach(Console.WriteLine);
        }
        public void MembershipList()
        {
            var memberships = membershipRep.GetAll();
            memberships.Select(membership => membership.Print()).ToList().ForEach(Console.WriteLine);
        }
        public void GetOldestMember()
        {
            Console.WriteLine("The oldest member: \n");
            Console.WriteLine(memberService.GetOldestMember(memberRep.GetAll()).Print());
        }
    }
}
