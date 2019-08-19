using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Firebase.Database;
using Firebase.Database.Query;
using MasterDetailsPage.Models;


namespace MasterDetailsPage.Services
{
    public class FirebaseService
    {
        FirebaseClient firebase;

        public FirebaseService()
        {
             firebase = new FirebaseClient("https://xamarinfirebase-a0848.firebaseio.com/");
        }


        //Getting all Decisions
        public async Task<List<Decision>> GetAllDecisions()
        {

            return (await firebase
              .Child("Decisions")
              .OnceAsync<Decision>()).Select(item => new Decision
              {
                  id = item.Object.id,
                  name = item.Object.name,
                  positive = item.Object.positive,
                  negative = item.Object.negative
              }).ToList();
        }

        //Getting all Decisions
        public async Task<List<Case>> GetAllCases()
        {

            return (await firebase
              .Child("Cases")
              .OnceAsync<Case>()).Select(item => new Case
              {
                  id = item.Object.id,
                  decisionId = item.Object.decisionId,
                  name = item.Object.name,
                  importance = item.Object.importance,
                  type = item.Object.type
              }).ToList();
        }

        public async Task<List<User>> GetAllUsers()
        {

            return (await firebase
              .Child("User")
              .OnceAsync<User>()).Select(item => new User
              {
                    name = item.Object.name,
                    username = item.Object.username,
                    email = item.Object.email,
                    password = item.Object.password,
              }).ToList();
        }




        //Add Decision
        public async Task AddDecision(int id, string name,int positive, int negative )
        {

            await firebase
              .Child("Decisions")
              .PostAsync(new Decision() { id = id, name = name, positive = positive, negative = negative });
        }

        //Add Decision
        public async Task AddCase(int id,int decisionId, string name, int importance, string type)
        {
                await firebase
              .Child("Cases")
              .PostAsync(new Case() { id = id,decisionId = decisionId, name = name,importance = importance, type = type });
        }


        //Add Decision
        public async Task AddUser(int id, String name,String username, String email,String password )
        {
        await firebase
          .Child("User")
          .PostAsync(new User() {name=name, username = username, email = email, password = password });
        }


    } 
}
