using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMIS____GUI_Design
{
    internal class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = ProjectData.db"); //sets location of database file for application
        }

        public DbSet<Project> Projects { get; set; } //instantiates a list of projects from the DbSet object as an list called Projects
        //create DbSet object lists with getters and setters for other tables here
        public DbSet<StakeholderData> Stakeholders { get; set; }
        public DbSet<TaskData> Tasks { get; set; }
        public DbSet<ResourceData> Resources { get; set; }
        public DbSet<MilestoneData> Milestones { get; set; }
        public DbSet<RequirementData> Requirements { get; set; }
        //join tables
        public DbSet<Resource_Task_Join> AssignedResources { get; set; }
        public DbSet<Stakeholder_Project_Join> AssignedStakeholders { get; set; }

    }
}
