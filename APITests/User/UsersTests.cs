using APIDemo;
using APIDemo.Models;
using NUnit.Framework;
using System;
using System.Linq;

namespace ApiTestsUser
{
    public class UsersTests
    {
        [Test]
        public void GetUserDetails()
        {
            var user = new ServiceCalls().GetUser(2);
            Assert.AreEqual(user.Data.Id, 2);
            Assert.AreEqual(user.Data.Email, "janet.weaver@reqres.in");
            Assert.AreEqual(user.Data.First_name, "Janet");
            Assert.AreEqual(user.Data.Last_name, "Weaver");
            Assert.AreEqual(user.Data.Avatar, "https://reqres.in/img/faces/2-image.jpg");
        }

        [Test]
        public void GetUserLists()
        {
            var userLists = new ServiceCalls().GetUserLists();

            Assert.AreEqual(userLists.Page, 1);
            Assert.AreEqual(userLists.Per_page, 6);
            Assert.AreEqual(userLists.Total_pages, 2);
            Assert.AreEqual(userLists.Data.Count, 6);

            Assert.AreEqual(userLists.Data[0].Id, 1);
            Assert.AreEqual(userLists.Data[1].Id, 2);
            Assert.AreEqual(userLists.Data[2].Id, 3);
            Assert.AreEqual(userLists.Data[3].Id, 4);
            Assert.AreEqual(userLists.Data[4].Id, 5);
            Assert.AreEqual(userLists.Data[5].Id, 6);

            var getSelectedUser = userLists.Data.Where(x => x.Id == 1).Select(x => x);
            foreach (var item in getSelectedUser)
            {
                Assert.AreEqual(item.Email, "george.bluth@reqres.in");
                Assert.AreEqual(item.First_name, "George");
                Assert.AreEqual(item.Last_name, "Bluth");
                Assert.AreEqual(item.Avatar, "https://reqres.in/img/faces/1-image.jpg");
            }

            getSelectedUser = userLists.Data.Where(x => x.Id == 2).Select(x => x);
            foreach (var item in getSelectedUser)
            {
                Assert.AreEqual(item.First_name, "Janet");
                Assert.AreEqual(item.Last_name, "Weaver");
            }

            getSelectedUser = userLists.Data.Where(x => x.Id == 3).Select(x => x);
            foreach (var item in getSelectedUser)
            {
                Assert.AreEqual(item.First_name, "Emma");
                Assert.AreEqual(item.Last_name, "Wong");
            }

            getSelectedUser = userLists.Data.Where(x => x.Id == 4).Select(x => x);
            foreach (var item in getSelectedUser)
            {
                Assert.AreEqual(item.First_name, "Eve");
                Assert.AreEqual(item.Last_name, "Holt");
            }

            getSelectedUser = userLists.Data.Where(x => x.Id == 5).Select(x => x);
            foreach (var item in getSelectedUser)
            {
                Assert.AreEqual(item.First_name, "Charles");
                Assert.AreEqual(item.Last_name, "Morris");
            }

            getSelectedUser = userLists.Data.Where(x => x.Id == 6).Select(x => x);
            foreach (var item in getSelectedUser)
            {
                Assert.AreEqual(item.First_name, "Tracey");
                Assert.AreEqual(item.Last_name, "Ramos");
            }
        }


        [Test]
        public void TestCreateAndUpdateUser()
        {
            var userObject = new User
            {
                Name = "Deepak",
                Job = "SE"
            };
            var user = new ServiceCalls().CreateUser(userObject);            
            Assert.AreEqual(user.Name, "Deepak");
            Assert.AreEqual(user.Job, "SE");

            var tempID = user.Id;
            user = new ServiceCalls().GetUser(tempID);
            user.Name = "Deepak1";
            user.Job= "SE1";
            Assert.AreEqual(user.Name, "Deepak1");
            Assert.AreEqual(user.Job, "SE1");
        }
    }
}