﻿using System;

namespace NetSampleArch.Application.UseCases.AddPerson.Models
{
    public class AddPersonUseCaseModel : BaseUseCaseModel
    {

        public Guid Id { get; }
        public string CreatedBy { get; }
        public DateTime CreatedAt { get; }
        public string UpdatedBy { get; }
        public DateTime? UpdatedAt { get; }
        public TimeSpan RowVersion { get; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public AddPersonUseCaseModel(string executionUser, string createdBy, DateTime createdAt, string updatedBy, DateTime? updatedAt, 
            TimeSpan rowVersion, string name, string address, string phone)
            : base(executionUser)
        {
            CreatedBy = createdBy;
            CreatedAt = createdAt;
            UpdatedBy = updatedBy;
            UpdatedAt = updatedAt;
            RowVersion = rowVersion;
            Name = name;
            Address = address;
            Phone = phone;
        }
    }
}