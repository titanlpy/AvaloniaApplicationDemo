using DataGridExample.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AvaloniaApplicationDemo.ViewModels
{
    public class WorkTabControlViewModel : ViewModelBase
    {
        public List<UserModel> Users { get; set; }

        public WorkTabControlViewModel()
        {
            Users = new List<UserModel>(GenerateUserTable());
        }

        private List<UserModel> GenerateUserTable()
        {
            List<UserModel> retUsers = new List<UserModel>()
            {
                new UserModel()
                {
                    OpdNo="A001",
                    Name="无忧",
                    Reserve="体检",
                    Client="问诊1",
                    State=1,
                    IsNow = true,
                    IsWait = false
                },
                    new UserModel()
                {
                    OpdNo="A002",
                    Name="图片",
                    Reserve="体检",
                    Client="问诊1",
                    State=0,
                      IsNow = false,
                    IsWait = true
                },
                        new UserModel()
                {
                   OpdNo="A003",
                    Name="研发",
                    Reserve="体检",
                    Client="问诊1",
                    State=0,
                       IsNow = false,
                    IsWait = true
                },
                new UserModel()
                {
                   OpdNo="A004",
                    Name="图片",
                    Reserve="体检",
                    Client="问诊1",
                    State=0,
                       IsNow = false,
                    IsWait = true
                }
            };
            return retUsers;
        }

    }
}
